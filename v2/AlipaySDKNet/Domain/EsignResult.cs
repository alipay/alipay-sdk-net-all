using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EsignResult Data Structure.
    /// </summary>
    [Serializable]
    public class EsignResult : AopObject
    {
        /// <summary>
        /// 用工企业和用户以及税筹服务商签订的三方协议的协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 用工企业和用户以及税筹ISV签订的三方协议的协议链接
        /// </summary>
        [XmlElement("agreement_url")]
        public string AgreementUrl { get; set; }

        /// <summary>
        /// 报税模式，有限枚举。 SUMMARY_DECLARATION（汇总申报）
        /// </summary>
        [XmlElement("apply_dutiable_mode_enum")]
        public string ApplyDutiableModeEnum { get; set; }

        /// <summary>
        /// 税筹ISV入驻平台后，平台提供的企业编码
        /// </summary>
        [XmlElement("contractor_code")]
        public string ContractorCode { get; set; }

        /// <summary>
        /// 税筹ISV公司名称
        /// </summary>
        [XmlElement("contractor_name")]
        public string ContractorName { get; set; }

        /// <summary>
        /// 用户签约授权的支付宝账号登陆标识，默认脱敏。
        /// </summary>
        [XmlElement("employee_alipay_logon_id")]
        public string EmployeeAlipayLogonId { get; set; }

        /// <summary>
        /// 用工企业入驻后平台后，平台提供的企业编码
        /// </summary>
        [XmlElement("employer_code")]
        public string EmployerCode { get; set; }

        /// <summary>
        /// 用户在用工企业的唯一性身份标识
        /// </summary>
        [XmlElement("identification_in_belonging_employer")]
        public string IdentificationInBelongingEmployer { get; set; }

        /// <summary>
        /// 签约流程创建时提供的out_biz_no，如流程创建的时候未提供，则查询结果也为空
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发薪模式，有限枚举。 DIRECT_PAYMENT（直接发薪）
        /// </summary>
        [XmlElement("pay_salary_mode_enum")]
        public string PaySalaryModeEnum { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 三方协议状态 1.SIGNED（已签约 2.TERMINATING(解约中) 3.TERMINATED(已解约)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 税优模式，有限枚举。1.TEMPORARY_TAX_REGISTRATION（临时税务登记 ）2. NATURAL_PERSON_LEVIED（自然人代征）
        /// </summary>
        [XmlElement("tax_optimization_mode")]
        public string TaxOptimizationMode { get; set; }

        /// <summary>
        /// 解约时间
        /// </summary>
        [XmlElement("termination_time")]
        public string TerminationTime { get; set; }

        /// <summary>
        /// 用工企业和灵工服务商的二方合作状态，有限枚举：  1、SIGNED（已签约）  2、TERMINATED(已解约)
        /// </summary>
        [XmlElement("two_party_status")]
        public string TwoPartyStatus { get; set; }
    }
}
