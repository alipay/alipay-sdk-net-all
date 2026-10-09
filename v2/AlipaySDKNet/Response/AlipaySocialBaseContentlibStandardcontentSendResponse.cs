using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentSendResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardcontentSendResponse : AopResponse
    {
        /// <summary>
        /// result_msg为请求openAPI接口后返回的结果message
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
