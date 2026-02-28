using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceServiceSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceServiceSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务项目id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
