using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionModifyResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionModifyResponse : AopResponse
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
