using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementAgentSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementAgentSignModel : AopObject
    {
        /// <summary>
        /// 【描述】请按当前接入的方式进行填充，且输入值必须为文档中的参数取值范围。
        /// </summary>
        [XmlElement("access_params")]
        public AccessParams AccessParams { get; set; }

        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。 格式规则：支持大写小写字母和数字，最长32位。 商户系统按需自定义传入，用于区分用户在同一产品码、同一签约场景下，签订的多份代扣协议。
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户在商户侧APP的登录名，如手机号、邮箱、用户名等。用于在签约页面上做展示，脱敏规范为:手机号，显示前3和后2位；email，显示用户名的前3位+*+@域名；如果都不是，隐藏中间四位。如果商户明文传入，支付宝会对内容做脱敏展示。
        /// </summary>
        [XmlElement("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 个人签约产品码，商户和支付宝签约时确定，商户可咨询技术支持。
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }
    }
}
