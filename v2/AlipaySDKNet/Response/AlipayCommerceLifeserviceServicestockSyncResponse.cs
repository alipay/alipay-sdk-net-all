using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceServicestockSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceServicestockSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务项目id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
