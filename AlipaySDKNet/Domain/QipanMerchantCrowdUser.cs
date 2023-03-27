using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QipanMerchantCrowdUser Data Structure.
    /// </summary>
    [Serializable]
    public class QipanMerchantCrowdUser : AopObject
    {
        /// <summary>
        /// 支付宝小程序app_id，当encrypt_identity_type=OPEN_ID此值必传，且应传入openId对应的appId
        /// </summary>
        [XmlElement("alipay_app_id")]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 用户身份信息为手机号码时，加密方式如下： encrypt_identity_type=SHA256_MOBILE，encrypt_identity_id = sha256(手机号码)   用户身份信息为支付宝openId时，加密方式如下： encrypt_identity_type=OPEN_ID，encrypt_identity_id = 支付宝openId   用户身份信息为idfa时，加密方式如下： encrypt_identity_type=SHA256_IDFA，encrypt_identity_id = sha256(idfa)  用户身份信息为oaid时，加密方式如下： encrypt_identity_type=SHA256_OAID，encrypt_identity_id = sha256(oaid)
        /// </summary>
        [XmlElement("encrypt_identity_id")]
        public string EncryptIdentityId { get; set; }

        /// <summary>
        /// 用身份信息类型-加密手机号，枚举如下：  SHA256_MOBILE-sha256加密的手机号码 OPEN_ID-支付宝openId SHA256_IDFA-sha256加密的idfa SHA256_OAID-sha256加密的oaid
        /// </summary>
        [XmlElement("encrypt_identity_type")]
        public string EncryptIdentityType { get; set; }
    }
}
