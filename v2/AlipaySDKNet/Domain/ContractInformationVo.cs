using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractInformationVo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractInformationVo : AopObject
    {
        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同周期
        /// </summary>
        [XmlElement("contract_period")]
        public string ContractPeriod { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_title")]
        public string ContractTitle { get; set; }

        /// <summary>
        /// 对方公司名称
        /// </summary>
        [XmlElement("other_company")]
        public string OtherCompany { get; set; }

        /// <summary>
        /// 对方公司所在国家（地区）
        /// </summary>
        [XmlElement("other_company_location")]
        public string OtherCompanyLocation { get; set; }

        /// <summary>
        /// 我方公司code
        /// </summary>
        [XmlElement("our_company")]
        public string OurCompany { get; set; }

        /// <summary>
        /// 本方公司名称
        /// </summary>
        [XmlElement("our_company_name")]
        public string OurCompanyName { get; set; }

        /// <summary>
        /// 机房信息
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 合同所属的租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
