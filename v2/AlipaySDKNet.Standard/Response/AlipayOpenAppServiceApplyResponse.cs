using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceApplyResponse.
    /// </summary>
    public class AlipayOpenAppServiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
