using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractStatusModifyModel : AopObject
    {
        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business")]
        public string Business { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 源系统id
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
