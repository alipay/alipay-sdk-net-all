using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreeementPreViewReq Data Structure.
    /// </summary>
    [Serializable]
    public class AgreeementPreViewReq : AopObject
    {
        /// <summary>
        /// 协议状态枚举值(INIT/ENABLE/FREEZE/DISABLE)
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 合同模板code带版本号
        /// </summary>
        [XmlElement("agreement_version")]
        public string AgreementVersion { get; set; }

        /// <summary>
        /// 协议类型Code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 机构信息
        /// </summary>
        [XmlElement("fund_supplier")]
        public InstitutionVO FundSupplier { get; set; }
    }
}
