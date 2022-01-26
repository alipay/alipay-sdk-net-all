using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTaxbillSigncodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTaxbillSigncodeCreateModel : AopObject
    {
        /// <summary>
        /// 签约完成之后用户点击签约完成的回跳url，自定义提供，只支持支付宝端内的小程序跳转和H5跳转，不支持APP间跳转。入无特殊需要，可忽略此字段。
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

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
        /// 用户的签约支付宝账号，默认必输，限定只有登录号匹配的支付宝用户才能进行签约。
        /// </summary>
        [XmlElement("employee_alipay_logon_id")]
        public string EmployeeAlipayLogonId { get; set; }

        /// <summary>
        /// 雇员的证件编号，如提供，雇员证件姓名（employee_name)也不能为空。当提供了雇员的实名信息，则签约时会校验签约时的用户实名信息，如不匹配则签约会被拦截
        /// </summary>
        [XmlElement("employee_id_card_no")]
        public string EmployeeIdCardNo { get; set; }

        /// <summary>
        /// 雇员真实姓名，如提供，雇员证件号码（employee_id_card_no)也不能为空
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 用工企业在平台的唯一性身份标识，入驻平台成功后由平台方提供
        /// </summary>
        [XmlElement("employer_code")]
        public string EmployerCode { get; set; }

        /// <summary>
        /// 用户在用工企业的唯一性身份标识，用户单位自定义参数，用于用工单位识别雇员身份，签约完成后的异步通知回回传此参数。
        /// </summary>
        [XmlElement("identification_in_belonging_employer")]
        public string IdentificationInBelongingEmployer { get; set; }

        /// <summary>
        /// 产品码，固定值：TAX_BILL_PLATFORM
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 税优模式，有限枚，实际传递的值依赖具体业务情况。1.TEMPORARY_TAX_REGISTRATION（临时税务登记 ）2. NATURAL_PERSON_LEVIED（自然人代征）
        /// </summary>
        [XmlElement("tax_optimization_mode")]
        public string TaxOptimizationMode { get; set; }
    }
}
