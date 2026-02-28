using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceServiceDeleteResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceServiceDeleteResponse : AopResponse
    {
        /// <summary>
        /// 服务项目id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
