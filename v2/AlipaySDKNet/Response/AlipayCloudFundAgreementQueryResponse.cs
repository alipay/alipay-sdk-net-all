using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundAgreementQueryResponse.
    /// </summary>
    public class AlipayCloudFundAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户签约成功后的协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 返回脱敏的支付宝账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 协议失效时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约主体类型
        /// </summary>
        [XmlElement("pricipal_type")]
        public string PricipalType { get; set; }

        /// <summary>
        /// 签约协议的场景。
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 协议签约时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 协议当前状态 1. TEMP：暂存，协议未生效过； 2. NORMAL：正常； 3. STOP：暂停
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。 默认为PARTNER。
        /// </summary>
        [XmlElement("third_party_type")]
        public string ThirdPartyType { get; set; }

        /// <summary>
        /// 协议生效时间，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
