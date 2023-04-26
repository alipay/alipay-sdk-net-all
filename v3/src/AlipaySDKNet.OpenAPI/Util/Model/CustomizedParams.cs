using System.Collections.Generic;

namespace AlipaySDKNet.OpenAPI.Util.Model
{
    public class CustomizedParams
    {
        /// <summary>
        /// 系统服务商的第三方应用代商家的应用或小程序模板调用支付宝OpenAPI时所传入的授权凭证
        /// </summary>
        public string AppAuthToken { get; set; }
        
        /// <summary>
        /// 额外的header参数
        /// </summary>
        public Dictionary<string, string> HeaderParams { get; set; }
        
        /// <summary>
        /// 额外的query参数
        /// </summary>
        public Dictionary<string, string> QueryParams { get; set; }
        
        /// <summary>
        /// body字符串，若bodyContent有值，则请求的body内容为bodyContent
        /// </summary>
        public string BodyContent { get; set; }
    }
}