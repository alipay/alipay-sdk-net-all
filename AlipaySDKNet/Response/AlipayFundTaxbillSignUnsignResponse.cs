using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTaxbillSignUnsignResponse.
    /// </summary>
    public class AlipayFundTaxbillSignUnsignResponse : AopResponse
    {
        /// <summary>
        /// 解约受理结果
        /// </summary>
        [XmlElement("accept")]
        public bool Accept { get; set; }

        /// <summary>
        /// 用工企业和用户以及税筹服务商签订的三方协议的协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 已弃用字段，签约结果状态请参考sign_status。三方协议状态（已过时） 1.REGISTERED（已签约） 2.TERMINATED（已解约）
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 场景码，固定值：SIGN
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 税筹服务商入驻平台后，平台提供的企业编码
        /// </summary>
        [XmlElement("contractor_code")]
        public string ContractorCode { get; set; }

        /// <summary>
        /// 税筹服务商名称
        /// </summary>
        [XmlElement("contractor_name")]
        public string ContractorName { get; set; }

        /// <summary>
        /// 用工企业入驻后平台后，平台提供的企业编码
        /// </summary>
        [XmlElement("employer_code")]
        public string EmployerCode { get; set; }

        /// <summary>
        /// 解约受理失败错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 解约受理失败原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 用户在用工企业的唯一性身份标识
        /// </summary>
        [XmlElement("identification_in_belonging_employer")]
        public string IdentificationInBelongingEmployer { get; set; }

        /// <summary>
        /// 产品码，固定值：TAX_BILL_PLATFORM
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户的签约状态，如果解约处理成功，则返回此字段。参数取值为有限枚举：TERMINATED
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 税优模式，有限枚举。1.TEMPORARY_TAX_REGISTRATION（临时税务登记）2.NATURAL_PERSON_LEVIED（自然人代征）
        /// </summary>
        [XmlElement("tax_optimization_mode")]
        public string TaxOptimizationMode { get; set; }

        /// <summary>
        /// 解约时间
        /// </summary>
        [XmlElement("terminated_time")]
        public string TerminatedTime { get; set; }

        /// <summary>
        /// 已弃用字段，签约结果状态请参考sign_status。用户在平台的会员状态（已过时）：1.TAX_REGISTERED（完成税务注册）2.CONTRACT_TERMINATED（用户已解约）
        /// </summary>
        [XmlElement("user_status")]
        public string UserStatus { get; set; }
    }
}
