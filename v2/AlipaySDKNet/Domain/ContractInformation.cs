using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractInformation Data Structure.
    /// </summary>
    [Serializable]
    public class ContractInformation : AopObject
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
        /// 对方公司所在国家或地区
        /// </summary>
        [XmlElement("other_company_location")]
        public string OtherCompanyLocation { get; set; }

        /// <summary>
        /// 我方公司code
        /// </summary>
        [XmlElement("our_company")]
        public string OurCompany { get; set; }

        /// <summary>
        /// 我方公司名称
        /// </summary>
        [XmlElement("our_company_name")]
        public string OurCompanyName { get; set; }

        /// <summary>
        /// 机房信息
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 签署顺序
        /// </summary>
        [XmlElement("sign_order")]
        public string SignOrder { get; set; }

        /// <summary>
        /// 签署备注(最大100字)
        /// </summary>
        [XmlElement("sign_remark")]
        public string SignRemark { get; set; }

        /// <summary>
        /// 合同所属租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
