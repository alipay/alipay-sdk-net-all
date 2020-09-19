using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionOfflineResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionOfflineResponse : AopResponse
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
