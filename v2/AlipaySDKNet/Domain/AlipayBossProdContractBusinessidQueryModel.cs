using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractBusinessidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractBusinessidQueryModel : AopObject
    {
        /// <summary>
        /// 请求单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 来源系统ID
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 合同所在租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
