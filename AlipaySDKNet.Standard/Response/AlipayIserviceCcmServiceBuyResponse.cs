using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmServiceBuyResponse.
    /// </summary>
    public class AlipayIserviceCcmServiceBuyResponse : AopResponse
    {
        /// <summary>
        /// 服务实例id
        /// </summary>
        [XmlElement("service_instance_id")]
        public long ServiceInstanceId { get; set; }

        /// <summary>
        /// 商户在CCM的租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
