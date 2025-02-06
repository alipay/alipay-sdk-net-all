using System;
using System.Collections.Generic;
using Aop.Api.Parser;
using Aop.Api.Util;
using System.Text;
using System.Web;
using System.Net;
using Org.BouncyCastle.X509;
using Newtonsoft.Json;

namespace Aop.Api
{
    /// <summary>
    /// AOP客户端。
    /// </summary>
    public class DefaultAopClient : IAopClient
    {
        private string version;
        private string format;
        private string serverUrl;
        private string appId;
        private string privateKeyPem;
        private string signType = "RSA";
        private string charset;
        private string alipayPublicKey;
        private bool keyFromFile = false;
        public string return_url;

        public string notify_url;

        /// <summary>
        /// 当前SDK版本号，SDK打包发布时会自动修改该值
        /// </summary>
        public const string SDK_VERSION = "alipay-sdk-net-4.9.401.ALL";

        private CertEnvironment certEnvironment;

        private string encyptKey;
        private string encyptType = "AES";

        private WebUtils webUtils;

        private bool skipSign = false;

        public string Version
        {
            get { return version != null ? version : "1.0"; }
            set { version = value; }
        }

        public string Format
        {
            get { return format != null ? format : "json"; }
            set { format = value; }
        }

        public string AppId
        {
            get { return appId; }
            set { appId = value; }
        }


        public DefaultAopClient(AlipayConfig config)
        {
            this.serverUrl = config.ServerUrl;
            this.appId = config.AppId;
            this.format = config.Format;
            this.charset = config.Charset;
            this.signType = config.SignType;
            this.keyFromFile = false;
            this.privateKeyPem = config.PrivateKey;
            this.alipayPublicKey = config.AlipayPublicKey;

            //设置了支付宝公钥证书相关参数才初始化证书模式的运行环境
            if (!string.IsNullOrEmpty(config.AlipayPublicCertPath)
                || !string.IsNullOrEmpty(config.AlipayPublicCertContent))
            {
                CertParams certParams = new CertParams();
                certParams.AppCertPath = config.AppCertPath;
                certParams.AlipayPublicCertPath = config.AlipayPublicCertPath;
                certParams.RootCertPath = config.RootCertPath;
                certParams.AppCertContent = config.AppCertContent;
                certParams.AlipayPublicCertContent = config.AlipayPublicCertContent;
                certParams.RootCertContent = config.RootCertContent;
                this.certEnvironment = new CertEnvironment(certParams, this.signType);
            }


            this.encyptType = config.EncryptType;
            this.encyptKey = config.EncryptKey;

            this.webUtils = new WebUtils();
            this.webUtils.Timeout = config.ConnectTimeout;
            this.webUtils.ReadWriteTimeout = config.ReadTimeout;
            this.webUtils.CustomHeaders = config.CustomHeaders;
            if (!string.IsNullOrEmpty(config.ProxyHost))
            {
                this.webUtils.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }

            this.skipSign = config.SkipSign;
        }


        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem)
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, bool keyFromFile)
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.keyFromFile = keyFromFile;
            this.webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format)
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.format = format;
            this.webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
            : this(serverUrl, appId, privateKeyPem, format)
        {
            this.charset = charset;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType)
            : this(serverUrl, appId, privateKeyPem)
        {
            this.format = format;
            this.version = version;
            this.signType = signType;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey)
            : this(serverUrl, appId, privateKeyPem, format, version, signType)
        {
            this.alipayPublicKey = alipayPulicKey;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.charset = charset;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset, bool keyFromFile)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.keyFromFile = keyFromFile;
            this.charset = charset;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string charset, bool keyFromFile, CertParams certParams)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, null, charset, keyFromFile)
        {
            this.certEnvironment = new CertEnvironment(certParams, signType);
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset, string encyptKey)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey, charset)
        {
            this.encyptKey = encyptKey;
            this.encyptType = "AES";
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string charset, string encyptKey, CertParams certParams)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, null, charset, encyptKey)
        {
            this.certEnvironment = new CertEnvironment(certParams, signType);
        }

        public void SetTimeout(int timeout)
        {
            webUtils.Timeout = timeout;
        }

        public T Execute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return Execute<T>(request, null);
        }

        public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {

            return Execute<T>(request, accessToken, null);
        }

        public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
        {
            return Execute<T>(request, accessToken, appAuthToken, null);
        }

        public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string targetAppId) where T : AopResponse
        {
            ArgumentValidator.EnsureNull(certEnvironment, "检测到证书相关参数已初始化，证书模式下请改为调用CertificateExecute。");

            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = "utf-8";
            }

            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            // 添加协议级请求参数
            AopDictionary txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            txtParams.Add(AlipayConstants.METHOD, request.GetApiName());
            txtParams.Add(AlipayConstants.VERSION, apiVersion);
            txtParams.Add(AlipayConstants.ALIPAY_SDK, SDK_VERSION);
            txtParams.Add(AlipayConstants.APP_ID, appId);
            txtParams.Add(AlipayConstants.FORMAT, format);
            txtParams.Add(AlipayConstants.TIMESTAMP, DateTime.Now);
            txtParams.Add(AlipayConstants.ACCESS_TOKEN, accessToken);
            txtParams.Add(AlipayConstants.SIGN_TYPE, signType);
            txtParams.Add(AlipayConstants.TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(AlipayConstants.PROD_CODE, request.GetProdCode());
            txtParams.Add(AlipayConstants.CHARSET, charset);


            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
            {
                txtParams.Add(AlipayConstants.NOTIFY_URL, request.GetNotifyUrl());
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            }

            if (!string.IsNullOrEmpty(targetAppId))
            {
                txtParams.Add(AlipayConstants.TARGET_APP_ID, targetAppId);
            }

            if (request.GetNeedEncrypt())
            {

                if (string.IsNullOrEmpty(txtParams[AlipayConstants.BIZ_CONTENT]))
                {

                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(this.encyptKey) || string.IsNullOrEmpty(this.encyptType))
                {
                    throw new AopException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(this.encyptType))
                {
                    throw new AopException("api only support Aes!");

                }

                string encryptContent = AopUtils.AesEncrypt(this.encyptKey, txtParams[AlipayConstants.BIZ_CONTENT], this.charset);
                txtParams.Remove(AlipayConstants.BIZ_CONTENT);
                txtParams.Add(AlipayConstants.BIZ_CONTENT, encryptContent);
                txtParams.Add(AlipayConstants.ENCRYPT_TYPE, this.encyptType);
            }

            if (!skipSign)
            {
                // 添加签名参数
                txtParams.Add(AlipayConstants.SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, this.keyFromFile, signType));
            }

            // 是否需要上传文件
            string body;


            if (request is IAopUploadRequest<T>)
            {
                IAopUploadRequest<T> uRequest = (IAopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl + "?" + AlipayConstants.CHARSET + "=" + this.charset, txtParams, fileParams, this.charset);
            }
            else
            {
                body = webUtils.DoPost(this.serverUrl + "?" + AlipayConstants.CHARSET + "=" + this.charset, txtParams, this.charset);
            }

            T rsp;
            IAopParser<T> parser;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            ResponseParseItem item = ParseRespItem(request, body, parser, this.encyptKey, this.encyptType, charset);
            rsp = parser.Parse(item.RealContent, charset);

            CheckResponseSign(request, item.RespContent, rsp.IsError, parser);

            return rsp;
        }

        public T CertificateExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return CertificateExecute<T>(request, null);
        }

        public T CertificateExecute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {

            return CertificateExecute<T>(request, accessToken, null);
        }

        public T CertificateExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
        {
            return CertificateExecute<T>(request, accessToken, appAuthToken, null);
        }

        public T CertificateExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, String targetAppId) where T : AopResponse
        {
            ArgumentValidator.CheckNotNull(certEnvironment, "检测到证书相关参数未初始化，非证书模式下请改为调用Execute。");

            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = "utf-8";
            }

            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            // 添加协议级请求参数
            AopDictionary txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            txtParams.Add(AlipayConstants.METHOD, request.GetApiName());
            txtParams.Add(AlipayConstants.VERSION, apiVersion);
            txtParams.Add(AlipayConstants.ALIPAY_SDK, SDK_VERSION);
            txtParams.Add(AlipayConstants.APP_ID, appId);
            txtParams.Add(AlipayConstants.FORMAT, format);
            txtParams.Add(AlipayConstants.TIMESTAMP, DateTime.Now);
            txtParams.Add(AlipayConstants.ACCESS_TOKEN, accessToken);
            txtParams.Add(AlipayConstants.SIGN_TYPE, signType);
            txtParams.Add(AlipayConstants.TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(AlipayConstants.PROD_CODE, request.GetProdCode());
            txtParams.Add(AlipayConstants.CHARSET, charset);

            txtParams.Add(AlipayConstants.APP_CERT_SN, certEnvironment.AppCertSN);
            txtParams.Add(AlipayConstants.ALIPAY_ROOT_CERT_SN, certEnvironment.RootCertSN);


            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
            {
                txtParams.Add(AlipayConstants.NOTIFY_URL, request.GetNotifyUrl());
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            }

            if (!string.IsNullOrEmpty(targetAppId))
            {
                txtParams.Add(AlipayConstants.TARGET_APP_ID, targetAppId);
            }

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(txtParams[AlipayConstants.BIZ_CONTENT]))
                {

                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(this.encyptKey) || string.IsNullOrEmpty(this.encyptType))
                {
                    throw new AopException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(this.encyptType))
                {
                    throw new AopException("api only support Aes!");

                }

                string encryptContent = AopUtils.AesEncrypt(this.encyptKey, txtParams[AlipayConstants.BIZ_CONTENT], this.charset);
                txtParams.Remove(AlipayConstants.BIZ_CONTENT);
                txtParams.Add(AlipayConstants.BIZ_CONTENT, encryptContent);
                txtParams.Add(AlipayConstants.ENCRYPT_TYPE, this.encyptType);
            }

            if (!skipSign)
            {
                // 添加签名参数
                txtParams.Add(AlipayConstants.SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, this.keyFromFile, signType));
            }

            // 是否需要上传文件
            string body;


            if (request is IAopUploadRequest<T>)
            {
                IAopUploadRequest<T> uRequest = (IAopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl + "?" + AlipayConstants.CHARSET + "=" + this.charset, txtParams, fileParams, this.charset);
            }
            else
            {
                body = webUtils.DoPost(this.serverUrl + "?" + AlipayConstants.CHARSET + "=" + this.charset, txtParams, this.charset);
            }

            T rsp;
            IAopParser<T> parser;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            ResponseParseItem item = ParseRespItem(request, body, parser, this.encyptKey, this.encyptType, charset);
            rsp = parser.Parse(item.RealContent, charset);


            CheckResponseCertSign(request, item.RespContent, rsp.IsError, parser);

            return rsp;
        }

        public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return pageExecute<T>(request, null, null, "POST");
        }


        public T pageExecute<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
        {
            return pageExecute<T>(request, accessToken, null, reqMethod);
        }


        public T pageExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string reqMethod) where T : AopResponse
        {
            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = "utf-8";
            }

            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            AopDictionary txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            // 添加协议级请求参数
            txtParams.Add(AlipayConstants.METHOD, request.GetApiName());
            txtParams.Add(AlipayConstants.VERSION, apiVersion);
            txtParams.Add(AlipayConstants.ALIPAY_SDK, SDK_VERSION);
            txtParams.Add(AlipayConstants.APP_ID, appId);
            txtParams.Add(AlipayConstants.FORMAT, format);
            txtParams.Add(AlipayConstants.TIMESTAMP, DateTime.Now);
            txtParams.Add(AlipayConstants.ACCESS_TOKEN, accessToken);
            txtParams.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            txtParams.Add(AlipayConstants.SIGN_TYPE, signType);
            txtParams.Add(AlipayConstants.TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(AlipayConstants.PROD_CODE, request.GetProdCode());
            txtParams.Add(AlipayConstants.NOTIFY_URL, request.GetNotifyUrl());
            txtParams.Add(AlipayConstants.CHARSET, this.charset);
            txtParams.Add(AlipayConstants.RETURN_URL, request.GetReturnUrl());
            if (certEnvironment != null)
            {
                txtParams.Add(AlipayConstants.ALIPAY_ROOT_CERT_SN, certEnvironment.RootCertSN);
                txtParams.Add(AlipayConstants.APP_CERT_SN, certEnvironment.AppCertSN);
            }
            //字典排序
            IDictionary<string, string> sortedTxtParams = new SortedDictionary<string, string>(txtParams, StringComparer.Ordinal);
            txtParams = new AopDictionary(sortedTxtParams);

            if (!skipSign)
            {
                // 排序返回字典类型添加签名参数
                txtParams.Add(AlipayConstants.SIGN, AopUtils.SignAopRequest(sortedTxtParams, privateKeyPem, this.charset, this.keyFromFile, this.signType));
            }

            // 是否需要上传文件
            string body;

            if (request is IAopUploadRequest<T>)
            {
                IAopUploadRequest<T> uRequest = (IAopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl + "?" + AlipayConstants.CHARSET + "=" + this.charset, txtParams, fileParams, this.charset);
            }
            else
            {

                if (reqMethod.Equals("GET"))
                {
                    //拼接get请求的url
                    string tmpUrl = serverUrl;
                    if (txtParams != null && txtParams.Count > 0)
                    {
                        if (tmpUrl.Contains("?"))
                        {
                            tmpUrl = tmpUrl + "&" + WebUtils.BuildQuery(txtParams, charset);
                        }
                        else
                        {
                            tmpUrl = tmpUrl + "?" + WebUtils.BuildQuery(txtParams, charset);
                        }
                    }
                    body = tmpUrl;
                }
                else
                {
                    //输出post表单
                    body = BuildHtmlRequest(txtParams, reqMethod, reqMethod);
                }
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            return rsp;
        }

        private static ResponseParseItem ParseRespItem<T>(IAopRequest<T> request, string respBody, IAopParser<T> parser, string encryptKey, string encryptType, string charset) where T : AopResponse
        {
            string realContent;
            if (request.GetNeedEncrypt())
            {
                realContent = parser.EncryptSourceData(request, respBody, encryptType, encryptKey, charset);
            }
            else
            {
                realContent = respBody;
            }

            ResponseParseItem item = new ResponseParseItem
            {
                RealContent = realContent,
                RespContent = respBody
            };

            return item;

        }

        private void CheckResponseCertSign<T>(IAopRequest<T> request, string responseBody, bool isError, IAopParser<T> parser) where T : AopResponse
        {
            if (skipSign)
            {
                return;
            }
            if (request.GetApiName().Equals("alipay.open.app.alipaycert.download"))
            {
                return;
            }

            CertItem certItem = parser.GetCertItem(request, responseBody);
            if (certItem == null)
            {
                throw new AopException("sign check fail: Body is Empty!");
            }

            if (!isError || (isError && !string.IsNullOrEmpty(certItem.Sign)))
            {

                String currentAlipayPublicKey = LoadAlipayPublicKey(certItem);

                bool rsaCheckContent = AlipaySignature.RSACheckContent(certItem.SignSourceDate, certItem.Sign, currentAlipayPublicKey, charset, signType, false);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(certItem.SignSourceDate) && certItem.SignSourceDate.Contains("\\/"))
                    {
                        string sourceData = certItem.SignSourceDate.Replace("\\/", "/");
                        bool jsonCheck = AlipaySignature.RSACheckContent(sourceData, certItem.Sign, currentAlipayPublicKey, charset, signType, false);
                        if (!jsonCheck)
                        {
                            throw new AopException("sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AopException("sign check fail: check Sign and Data Fail!");
                    }
                }
            }
        }

        private String LoadAlipayPublicKey(CertItem certItem)
        {
            //如果响应的支付宝公钥证书序号已经缓存过，则直接使用缓存的公钥
            if (certEnvironment.ContainsAlipayPublicKey(certItem.CertSN))
            {
                return certEnvironment.GetAlipayPublicKey(certItem.CertSN);
            }

            //否则重新下载新的支付宝公钥证书并更新缓存
            AlipayOpenAppAlipaycertDownloadRequest request = new AlipayOpenAppAlipaycertDownloadRequest
            {
                BizContent = "{\"alipay_cert_sn\":\"" + certItem.CertSN + "\"}"
            };
            AlipayOpenAppAlipaycertDownloadResponse response = CertificateExecute(request);
            if (response.IsError)
            {
                throw new AopException("支付宝公钥证书校验失败，请确认是否为支付宝签发的有效公钥证书");
            }
            string alipayCertBase64 = response.AlipayCertContent;
            byte[] alipayCertBytes = Convert.FromBase64String(alipayCertBase64);
            string alipayCertContent = Encoding.UTF8.GetString(alipayCertBytes);
            if (!AntCertificationUtil.IsTrusted(alipayCertContent, certEnvironment.RootCertContent))
            {
                throw new AopException("支付宝公钥证书校验失败，请确认是否为支付宝签发的有效公钥证书");
            }

            X509Certificate alipayCert = AntCertificationUtil.ParseCert(alipayCertContent);
            String alipayCertSN = AntCertificationUtil.GetCertSN(alipayCert);
            string newAlipayPublicKey = AntCertificationUtil.ExtractPemPublicKeyFromCert(alipayCert);
            certEnvironment.AddNewAlipayPublicKey(alipayCertSN, newAlipayPublicKey);

            return newAlipayPublicKey;
        }

        private void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError, IAopParser<T> parser) where T : AopResponse
        {
            if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset) || skipSign)
            {
                return;
            }

            SignItem signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
            {
                throw new AopException("sign check fail: Body is Empty!");
            }

            if (!isError ||
                (isError && !string.IsNullOrEmpty(signItem.Sign)))
            {
                bool rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        string srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        bool jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile);
                        if (!jsonCheck)
                        {
                            throw new AopException(
                                "sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AopException(
                                    "sign check fail: check Sign and Data Fail!");
                    }
                }

            }
        }

        public string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, string strButtonValue)
        {
            //待请求参数数组
            IDictionary<string, string> dicPara = new Dictionary<string, string>();
            dicPara = sParaTemp;

            StringBuilder sbHtml = new StringBuilder();
            //sbHtml.Append("<head><meta http-equiv=\"Content-Type\" content=\"text/html\" charset= \"" + charset + "\" /></head>");

            sbHtml.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + this.serverUrl + "?charset=" + this.charset +
                 "' method='" + strMethod + "' style='display:none;'>");

            foreach (KeyValuePair<string, string> temp in dicPara)
            {

                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }

            //submit按钮控件请不要含有name属性
            sbHtml.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");
            // sbHtml.Append("<input type='submit' value='" + strButtonValue + "'></form></div>");

            //表单实现自动提交
            sbHtml.Append("<script>document.forms['alipaysubmit'].submit();</script>");

            return sbHtml.ToString();
        }

        public Dictionary<string, string> FilterPara(SortedDictionary<string, string> dicArrayPre)
        {
            Dictionary<string, string> dicArray = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> temp in dicArrayPre)
            {
                if (temp.Key.ToLower() != "sign" && temp.Key.ToLower() != "sign_type" && temp.Value != "" && temp.Value != null)
                {
                    dicArray.Add(temp.Key, temp.Value);
                }
            }

            return dicArray;

        }

        public static string CreateLinkStringUrlencode(Dictionary<string, string> dicArray, Encoding code)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + HttpUtility.UrlEncode(temp.Value, code) + "&");
            }

            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }

        public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return SdkExecute(request, null);
        }

        public T SdkExecute<T>(IAopRequest<T> request, string appAuthToken) where T : AopResponse
        {
            // 构造请求参数
            AopDictionary requestParams = buildRequestParams(request, null, appAuthToken);

            // 字典排序
            IDictionary<string, string> sortedParams = new SortedDictionary<String, String>(requestParams, StringComparer.Ordinal);
            AopDictionary sortedAopDic = new AopDictionary(sortedParams);

            // 参数签名
            String charset = String.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;

            if (!skipSign)
            {
                String signResult = AopUtils.SignAopRequest(sortedAopDic, privateKeyPem, charset, this.keyFromFile, this.signType);
                // 添加签名结果参数
                sortedAopDic.Add(AlipayConstants.SIGN, signResult);
            }

            // 参数拼接
            String signedResult = WebUtils.BuildQuery(sortedAopDic, charset);

            // 构造结果
            T rsp = (T)Activator.CreateInstance(typeof(T));
            rsp.Body = signedResult;
            return rsp;
        }


        private AopDictionary buildRequestParams<T>(IAopRequest<T> request, String accessToken, String appAuthToken) where T : AopResponse
        {
            // 默认参数
            AopDictionary oriParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            AopDictionary result = SerializeBizModel(oriParams, request);

            // 获取参数
            String charset = String.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;
            String apiVersion = String.IsNullOrEmpty(request.GetApiVersion()) ? this.Version : request.GetApiVersion();

            // 添加协议级请求参数，为空的参数后面会自动过滤，这里不做处理。
            result.Add(AlipayConstants.METHOD, request.GetApiName());
            result.Add(AlipayConstants.VERSION, apiVersion);
            result.Add(AlipayConstants.ALIPAY_SDK, SDK_VERSION);
            result.Add(AlipayConstants.APP_ID, appId);
            result.Add(AlipayConstants.FORMAT, format);
            result.Add(AlipayConstants.TIMESTAMP, DateTime.Now);
            result.Add(AlipayConstants.ACCESS_TOKEN, accessToken);
            result.Add(AlipayConstants.SIGN_TYPE, signType);
            result.Add(AlipayConstants.TERMINAL_TYPE, request.GetTerminalType());
            result.Add(AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo());
            result.Add(AlipayConstants.PROD_CODE, request.GetProdCode());
            result.Add(AlipayConstants.NOTIFY_URL, request.GetNotifyUrl());
            result.Add(AlipayConstants.CHARSET, charset);
            result.Add(AlipayConstants.RETURN_URL, request.GetReturnUrl());
            result.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            if (certEnvironment != null)
            {
                result.Add(AlipayConstants.ALIPAY_ROOT_CERT_SN, certEnvironment.RootCertSN);
                result.Add(AlipayConstants.APP_CERT_SN, certEnvironment.AppCertSN);
            }


            if (request.GetNeedEncrypt())
            {
                if (String.IsNullOrEmpty(result[AlipayConstants.BIZ_CONTENT]))
                {
                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (String.IsNullOrEmpty(this.encyptKey) || String.IsNullOrEmpty(this.encyptType))
                {
                    throw new AopException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(this.encyptType))
                {
                    throw new AopException("api only support Aes!");
                }

                String encryptContent = AopUtils.AesEncrypt(this.encyptKey, result[AlipayConstants.BIZ_CONTENT], this.charset);
                result.Remove(AlipayConstants.BIZ_CONTENT);
                result.Add(AlipayConstants.BIZ_CONTENT, encryptContent);
                result.Add(AlipayConstants.ENCRYPT_TYPE, this.encyptType);
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestParams"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private AopDictionary SerializeBizModel<T>(AopDictionary requestParams, IAopRequest<T> request) where T : AopResponse
        {
            AopDictionary result = requestParams;
            Boolean isBizContentEmpty = !requestParams.ContainsKey(AlipayConstants.BIZ_CONTENT) || String.IsNullOrEmpty(requestParams[AlipayConstants.BIZ_CONTENT]);
            if (isBizContentEmpty && request.GetBizModel() != null)
            {
                AopObject bizModel = request.GetBizModel();
                String content = Serialize(bizModel);
                result.Add(AlipayConstants.BIZ_CONTENT, content);
            }
            return result;
        }

        /// <summary>
        /// AopObject序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private String Serialize(AopObject obj)
        {
            // 使用AopModelParser序列化对象
            AopModelParser parser = new AopModelParser();
            IDictionary<object, object> jo = parser.serializeAopObject(obj);
            JsonSerializerSettings jsetting = new JsonSerializerSettings();
            jsetting.NullValueHandling = NullValueHandling.Ignore;
            return JsonConvert.SerializeObject(jo, Formatting.None, jsetting);
        }
    }
}
