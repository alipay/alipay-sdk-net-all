using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskDeviceinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskDeviceinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备原子风险
        /// </summary>
        [XmlElement("atomic_risk")]
        public string AtomicRisk { get; set; }
    }
}
