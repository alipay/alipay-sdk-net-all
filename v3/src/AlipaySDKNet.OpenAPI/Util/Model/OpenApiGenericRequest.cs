using System;
using System.Collections.Generic;
using System.IO;

namespace AlipaySDKNet.OpenAPI.Util.Model
{
    public class OpenApiGenericRequest
    {
        /// <summary>
        /// 系统服务商的第三方应用代商家的应用或小程序模板调用支付宝OpenAPI时所传入的授权凭证
        /// </summary>
        public string AppAuthToken { get; set; }
        
        /// <summary>
        /// path参数
        /// </summary>
        public Dictionary<string, Object> PathParams { get; set; }
        
        /// <summary>
        /// query参数
        /// </summary>
        public Dictionary<string, Object> QueryParams { get; set; }
        
        /// <summary>
        /// body参数
        /// </summary>
        public Dictionary<string, Object> BodyParams { get; set; }
        
        /// <summary>
        /// 业务参数（废弃，请使用 BodyParams）
        /// </summary>
        public Dictionary<string, Object> BizParams { get; set; }
        
        /// <summary>
        /// 文件参数（fileParams不为空则表示文件上传）
        /// </summary>
        public Dictionary<string, Stream> FileParams { get; set; }
        
        /// <summary>
        /// 额外的header参数
        /// </summary>
        public Dictionary<string, string> HeaderParams { get; set; }
    }
}