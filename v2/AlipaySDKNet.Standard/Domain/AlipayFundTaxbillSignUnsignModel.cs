using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTaxbillSignUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTaxbillSignUnsignModel : AopObject
    {
        /// <summary>
        /// 场景码，固定值：SIGN
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 税筹服务商在平台的唯一性身份标识，入驻平台成功后由平台方提供
        /// </summary>
        [XmlElement("contractor_code")]
        public string ContractorCode { get; set; }

        /// <summary>
        /// 用工企业在平台的唯一性身份标识，入驻平台成功后由平台方提供
        /// </summary>
        [XmlElement("employer_code")]
        public string EmployerCode { get; set; }

        /// <summary>
        /// 用户在用工企业的唯一性身份标识，用户单位自定义参数，用于用工单位识别雇员身份
        /// </summary>
        [XmlElement("identification_in_belonging_employer")]
        public string IdentificationInBelongingEmployer { get; set; }

        /// <summary>
        /// 产品码，固定值：TAX_BILL_PLATFORM
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 税优模式，有限枚举。1.TEMPORARY_TAX_REGISTRATION（临时税务登记 ）2. NATURAL_PERSON_LEVIED（自然人代征）
        /// </summary>
        [XmlElement("tax_optimization_mode")]
        public string TaxOptimizationMode { get; set; }
    }
}
