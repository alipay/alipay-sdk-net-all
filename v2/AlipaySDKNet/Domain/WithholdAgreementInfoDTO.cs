using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithholdAgreementInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WithholdAgreementInfoDTO : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。（只有签约成功时才会返回）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 返回脱敏的支付宝账号。
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户代扣协议的失效时间，格式为yyyy-MM-dd HH:mm:ss。（只有签约成功才会返回）
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 当前签约的协议场景。
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 支付宝代扣协议的实际签约时间，格式为yyyy-MM-dd HH:mm:ss。(只有签约成功才会返回)
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 协议解约时间，状态为WITHHOLD_CANCEL必传
        /// </summary>
        [XmlElement("unsign_time")]
        public string UnsignTime { get; set; }

        /// <summary>
        /// 用户代扣协议的实际生效时间，格式为yyyy-MM-dd HH:mm:ss。（只有签约成功才会返回）
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
