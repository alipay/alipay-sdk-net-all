using System;
using System.IO;
using System.Text;
using Aop.Api.Parser;
using Aop.Api.Util;
using System.Net;

namespace Aop.Api
{
    public class AlipayMobilePublicMultiMediaClient : IAopClient
    {
        private string version;
        private string format;
        private string serverUrl;
        private string appId;
        private string privateKeyPem;
        private string signType = "RSA";
        private string charset;
        private bool keyFromFile = true;

        private WebUtils webUtils;

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

        //该构造函数默认从文件读取privateKey，privateKeyPem参数请指定私钥文件路径
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
            this.format = format;
            this.charset = charset;
        }

        //当指定不从文件读取privateKey时（即指定keyFromFile=false），privateKeyPem参数可以直接传私钥字符串，此时私钥内容请清除-----BEGIN RSA PRIVATE KEY-----头和-----END RSA PRIVATE KEY-----尾
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, bool keyFromFile, string format, string charset)
            : this(serverUrl, appId, privateKeyPem, format, charset)
        {
            this.keyFromFile = keyFromFile;
        }

        //该构造函数默认从文件读取privateKey，privateKeyPem参数请指定私钥文件路径
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format, string charset, string version, string signType)
            : this(serverUrl, appId, privateKeyPem, format, charset)
        {
            this.version = version;
            this.signType = signType;
        }

        //当指定不从文件读取privateKeyPem时（即指定keyFromFile=false），privateKeyPem参数可以直接传私钥字符串，此时私钥内容请清除-----BEGIN RSA PRIVATE KEY-----头和-----END RSA PRIVATE KEY-----尾
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, bool keyFromFile, string format, string charset, string version, string signType)
            : this(serverUrl, appId, privateKeyPem, keyFromFile, format, charset)
        {
            this.version = version;
            this.signType = signType;
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
            AlipayMobilePublicMultiMediaDownloadRequest multiMediaDownloadRequest = ((AlipayMobilePublicMultiMediaDownloadRequest)request);
            // 添加协议级请求参数
            AopDictionary txtParams = new AopDictionary(request.GetParameters());
            txtParams.Add(AlipayConstants.METHOD, request.GetApiName());
            txtParams.Add(AlipayConstants.VERSION, Version);
            txtParams.Add(AlipayConstants.APP_ID, appId);
            txtParams.Add(AlipayConstants.FORMAT, format);
            txtParams.Add(AlipayConstants.TIMESTAMP, DateTime.Now);
            txtParams.Add(AlipayConstants.ACCESS_TOKEN, accessToken);
            txtParams.Add(AlipayConstants.SIGN_TYPE, signType);
            txtParams.Add(AlipayConstants.TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(AlipayConstants.PROD_CODE, request.GetProdCode());

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            }


            // 添加签名参数
            txtParams.Add(AlipayConstants.SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, keyFromFile, signType));

            Stream outStream = multiMediaDownloadRequest.stream;
            AopResponse rsp = DoGet(txtParams, outStream);

            return (T)rsp;

        }

        private AopResponse DoGet(AopDictionary parameters, Stream outStream)
        {
            AlipayMobilePublicMultiMediaDownloadResponse response = null;

            string url = this.serverUrl;
            System.Console.WriteLine(url);
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + WebUtils.BuildQuery(parameters, charset);
                }
                else
                {
                    url = url + "?" + WebUtils.BuildQuery(parameters, charset);
                }
            }

            HttpWebRequest req = webUtils.GetWebRequest(url, "GET");
            req.ContentType = "application/x-www-form-urlencoded;charset=" + charset;

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            if (rsp.StatusCode == HttpStatusCode.OK)
            {
                if (rsp.ContentType.ToLower().Contains("text/plain"))
                {
                    Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    string body = webUtils.GetResponseAsString(rsp, encoding);
                    IAopParser<AlipayMobilePublicMultiMediaDownloadResponse> tp = new AopJsonParser<AlipayMobilePublicMultiMediaDownloadResponse>();
                    response = tp.Parse(body, charset);
                }
                else
                {
                    GetResponseAsStream(outStream, rsp);
                    response = new AlipayMobilePublicMultiMediaDownloadResponse();
                }
            }
            return response;
        }

        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        public void GetResponseAsStream(Stream outStream, HttpWebResponse rsp)
        {
            StringBuilder result = new StringBuilder();
            Stream stream = null;
            StreamReader reader = null;
            BinaryWriter writer = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream);

                writer = new BinaryWriter(outStream);

                //stream.CopyTo(outStream);
                int length = Convert.ToInt32(rsp.ContentLength);
                byte[] buffer = new byte[length];
                int rc = 0;
                while ((rc = stream.Read(buffer, 0, length)) > 0)
                {
                    outStream.Write(buffer, 0, rc);
                }
                outStream.Flush();
                outStream.Close();

            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }

        public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T pageExecute<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T pageExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string reqMethod) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T SdkExecute<T>(IAopRequest<T> request, string appAuthToken) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T CertificateExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return CertificateExecute(request, null, null);
        }

        public T CertificateExecute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {
            return CertificateExecute(request, accessToken, null);
        }

        public T CertificateExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string targetAppId) where T : AopResponse
        {
            throw new NotImplementedException();
        }

        public T CertificateExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string targetAppId) where T : AopResponse
        {
            throw new NotImplementedException();
        }
    }
}