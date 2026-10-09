using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcontractstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfcontractstatusSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("archive_files")]
        [XmlArrayItem("archive_files")]
        public List<ArchiveFiles> ArchiveFiles { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 合同标题
        /// </summary>
        [XmlElement("contract_title")]
        public string ContractTitle { get; set; }

        /// <summary>
        /// 合同查看地址
        /// </summary>
        [XmlElement("contract_view_url")]
        public string ContractViewUrl { get; set; }

        /// <summary>
        /// 合同金额，单位元
        /// </summary>
        [XmlElement("customer_contract_fee")]
        public string CustomerContractFee { get; set; }

        /// <summary>
        /// 合同金额币种
        /// </summary>
        [XmlElement("customer_contract_fee_currency_value")]
        public string CustomerContractFeeCurrencyValue { get; set; }

        /// <summary>
        /// 合同生效时间
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 创建甄零合同时传入的甄零合同/申请 ID
        /// </summary>
        [XmlElement("external_contract_id")]
        public string ExternalContractId { get; set; }

        /// <summary>
        /// 合同归档时间
        /// </summary>
        [XmlElement("filing_time")]
        public string FilingTime { get; set; }

        /// <summary>
        /// OB 签约对方主体名称
        /// </summary>
        [XmlElement("ob_sign_other_party_subject_name")]
        public string ObSignOtherPartySubjectName { get; set; }

        /// <summary>
        /// 请求幂等 ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
