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
        /// 用户身份信息密文，加密方式如下：  encrypt_identity_id = sha256(手机号码);
        /// </summary>
        [XmlElement("encrypt_identity_id")]
        public string EncryptIdentityId { get; set; }

        /// <summary>
        /// 用身份信息类型-加密手机号，枚举如下： mobile-手机号码
        /// </summary>
        [XmlElement("encrypt_identity_type")]
        public string EncryptIdentityType { get; set; }
    }
}
