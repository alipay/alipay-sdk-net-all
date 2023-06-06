using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Util
{
    public class GenericExecuteApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        private bool _loadTest = false;
        
        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }
        
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericExecuteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GenericExecuteApi()
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration()
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericExecuteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GenericExecuteApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericExecuteApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GenericExecuteApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// 通用方法
        /// </summary>
        /// <param name="path">The sub-path of the HTTP URL</param>
        /// <param name="method">The request method, one of "GET", "HEAD", "OPTIONS", "POST", "PUT", "PATCH" and "DELETE"</param>
        /// <param name="openApiGenericRequest">openApiGenericRequest</param>
        /// <returns></returns>
        public ApiResponse<Object> Execute(string path, HttpMethod method, OpenApiGenericRequest openApiGenericRequest)
        {
            if (openApiGenericRequest.BodyParams == null)
            {
                openApiGenericRequest.BodyParams = openApiGenericRequest.BizParams;
            }
            RequestOptions localVarRequestOptions = new RequestOptions();
            bool isFileUpload = openApiGenericRequest.FileParams != null && openApiGenericRequest.FileParams.Count > 0;

            string[] _contentTypes = new string[] {
                isFileUpload ? "multipart/form-data" : "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }
            
            //path参数
            if (openApiGenericRequest.PathParams != null && openApiGenericRequest.PathParams.Count > 0)
            {
                foreach (var param in openApiGenericRequest.PathParams)
                {
                    localVarRequestOptions.PathParameters.Add(param.Key, ClientUtils.ParameterToString(param.Value));
                }
            }

            //query参数
            if (openApiGenericRequest.QueryParams != null && openApiGenericRequest.QueryParams.Count > 0)
            {
                foreach (var param in openApiGenericRequest.QueryParams)
                {
                    localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", param.Key, param.Value));
                }
            }

            if (isFileUpload)
            {
                if (openApiGenericRequest.BodyParams != null)
                {
                    localVarRequestOptions.FormParameters.Add("data", ClientUtils.ParameterToString(openApiGenericRequest.BodyParams)); // form parameter
                }

                foreach (var param in openApiGenericRequest.FileParams)
                {
                    localVarRequestOptions.FileParameters.Add(param.Key, param.Value);
                }
            }
            else if (method != HttpMethod.Get && method != HttpMethod.Head)
            {
                localVarRequestOptions.Data = openApiGenericRequest.BodyParams;
            }

            if (!string.IsNullOrEmpty(openApiGenericRequest.AppAuthToken))
            {
                localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", openApiGenericRequest.AppAuthToken);
            }
            
            //额外非全局header参数
            if (openApiGenericRequest.HeaderParams != null && openApiGenericRequest.HeaderParams.Count > 0)
            {
                foreach (var param in openApiGenericRequest.HeaderParams)
                {
                    localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                }
            }
            localVarRequestOptions.Operation = "GenericExecuteApi.Execute";
            localVarRequestOptions.OperationIndex = 0;

            // make the HTTP request
            ApiResponse<Object> localVarResponse;
            
            switch (method)
            {
                case HttpMethod.Get:
                    localVarResponse = this.Client.Get<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                case HttpMethod.Post:
                    localVarResponse = this.Client.Post<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                case HttpMethod.Put:
                    localVarResponse = this.Client.Put<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                case HttpMethod.Delete:
                    localVarResponse = this.Client.Delete<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                case HttpMethod.Head:
                    localVarResponse = this.Client.Head<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                case HttpMethod.Options:
                    localVarResponse = this.Client.Options<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                case HttpMethod.Patch:
                    localVarResponse = this.Client.Patch<Object>(path, localVarRequestOptions, this.Configuration);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("method", method, null);
            }
            
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Execute", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        
        /// <summary>
        /// PageExecute
        /// </summary>
        /// <param name="method">方法名</param>
        /// <param name="httpMethod">GET/POST</param>
        /// <param name="bizParams">bizContent</param>
        /// <param name="authToken">用户授权凭证</param>
        /// <param name="appAuthToken">系统服务商的第三方应用代商家的应用或小程序模板调用支付宝OpenAPI时所传入的授权凭证</param>
        /// <param name="customizedParams">额外参数</param>
        /// <returns></returns>
        public string PageExecute(string method, string httpMethod, Dictionary<string, Object> bizParams, string authToken = null, string appAuthToken = null, CustomizedParams customizedParams = null)
        {
            IDictionary<string, string> handleParams = HandleParams(method, bizParams, authToken, appAuthToken, customizedParams);

            RequestOptions localVarRequestOptions = new RequestOptions();
            localVarRequestOptions.Operation = "GenericExecuteApi.PageExecute";
            localVarRequestOptions.OperationIndex = 0;
            string url = this.Client.GetBaseUrl(localVarRequestOptions, this.Configuration) + "/gateway.do";
            if (string.Equals("GET", httpMethod))
            {
                //拼接get请求的url
                if (url.Contains("?"))
                {
                    return url + "&" + BuildQuery(handleParams);
                }
                else
                {
                    return url + "?" + BuildQuery(handleParams);
                }
            }
            else
            {
                //输出post表单
                return BuildHtmlRequest(handleParams, httpMethod, httpMethod, url);
            }
        }

        /// <summary>
        /// SdkExecute
        /// </summary>
        /// <param name="method">方法名</param>
        /// <param name="bizParams">bizContent</param>
        /// <param name="authToken">用户授权凭证</param>
        /// <param name="appAuthToken">系统服务商的第三方应用代商家的应用或小程序模板调用支付宝OpenAPI时所传入的授权凭证</param>
        /// <param name="customizedParams">额外参数</param>
        /// <returns></returns>
        public string SdkExecute(string method, Dictionary<string, Object> bizParams, string authToken = null, string appAuthToken = null, CustomizedParams customizedParams = null)
        {
            IDictionary<string, string> handleParams = HandleParams(method, bizParams, authToken, appAuthToken, customizedParams);

            return BuildQuery(handleParams);
        }

        private IDictionary<string, string> HandleParams(string method, Dictionary<string, Object> bizParams, string authToken, string appAuthToken, CustomizedParams customizedParams)
        {
            Dictionary<string, string> appParams = new Dictionary<string, string>();
            Dictionary<string, string> systemParams = new Dictionary<string, string>();
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                appParams.Add("biz_content", customizedParams.BodyContent);
            }
            else if (bizParams != null && bizParams.TryGetValue("biz_content", out var value))
            {
                appParams.Add("biz_content", ClientUtils.ParameterToString(value));
            }

            if (bizParams != null)
            {
                foreach (var param in bizParams)
                {
                    if (!string.Equals("biz_content", param.Key))
                    {
                        appParams.Add(param.Key, ClientUtils.ParameterToString(param.Value));
                    }
                }
            }

            if (customizedParams != null)
            {
                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    appParams["app_auth_token"] = customizedParams.AppAuthToken;
                }

                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        systemParams.Add(param.Key, param.Value);
                    }
                }
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                appParams["app_auth_token"] = appAuthToken;
            }

            if (!string.IsNullOrEmpty(authToken))
            {
                systemParams["auth_token"] = authToken;
            }

            return this.Client.GetSortedMap(method, appParams, systemParams, _loadTest, Configuration);
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        private string BuildQuery(IDictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");

                    string encodedValue = HttpUtility.UrlEncode(value, Encoding.GetEncoding("utf-8"));

                    postData.Append(encodedValue);
                    hasParam = true;
                }
            }

            return postData.ToString();
        }

        private string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, string strButtonValue,
            string url)
        {
            //待请求参数数组
            IDictionary<string, string> dicPara = new Dictionary<string, string>();
            dicPara = sParaTemp;

            StringBuilder sbHtml = new StringBuilder();
            //sbHtml.Append("<head><meta http-equiv=\"Content-Type\" content=\"text/html\" charset= \"" + charset + "\" /></head>");

            sbHtml.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + url + "?charset=" + "UTF-8" +
                          "' method='" + strMethod + "' style='display:none;'>");

            foreach (KeyValuePair<string, string> temp in dicPara)
            {
                if (!string.IsNullOrEmpty(temp.Key) && !string.IsNullOrEmpty(temp.Value))
                {
                    sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
                }
            }

            //submit按钮控件请不要含有name属性
            sbHtml.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");
            // sbHtml.Append("<input type='submit' value='" + strButtonValue + "'></form></div>");

            //表单实现自动提交
            sbHtml.Append("<script>document.forms['alipaysubmit'].submit();</script>");

            return sbHtml.ToString();
        }

        public bool LoadTest
        {
            get => _loadTest;
            set => _loadTest = value;
        }
    }
}