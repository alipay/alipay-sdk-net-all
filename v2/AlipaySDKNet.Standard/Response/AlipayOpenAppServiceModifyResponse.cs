using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceModifyResponse.
    /// </summary>
    public class AlipayOpenAppServiceModifyResponse : AopResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
