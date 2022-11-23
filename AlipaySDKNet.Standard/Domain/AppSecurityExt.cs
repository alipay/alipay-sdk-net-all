using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppSecurityExt Data Structure.
    /// </summary>
    [Serializable]
    public class AppSecurityExt : AopObject
    {
        /// <summary>
        /// 支付宝公钥
        /// </summary>
        [XmlElement("alipay_public_key")]
        public string AlipayPublicKey { get; set; }

        /// <summary>
        /// 应用的APPID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        [XmlElement("cert_sn")]
        public string CertSn { get; set; }

        /// <summary>
        /// 应用私钥
        /// </summary>
        [XmlElement("partner_private_key")]
        public string PartnerPrivateKey { get; set; }

        /// <summary>
        /// 应用公钥
        /// </summary>
        [XmlElement("partner_public_key")]
        public string PartnerPublicKey { get; set; }

        /// <summary>
        /// 密钥类型
        /// </summary>
        [XmlElement("public_key_source")]
        public string PublicKeySource { get; set; }

        /// <summary>
        /// 应用的签名类型
        /// </summary>
        [XmlElement("signature_type")]
        public string SignatureType { get; set; }
    }
}
