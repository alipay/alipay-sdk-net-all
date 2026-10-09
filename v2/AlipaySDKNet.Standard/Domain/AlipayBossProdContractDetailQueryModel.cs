using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractDetailQueryModel : AopObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 合同编号(合同中心合同流水号)
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 是否需要主合同的PDF版本
        /// </summary>
        [XmlElement("is_pdf_required")]
        public bool IsPdfRequired { get; set; }

        /// <summary>
        /// 当前系统的名称
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
