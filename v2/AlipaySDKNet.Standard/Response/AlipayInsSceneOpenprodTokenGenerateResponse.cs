using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneOpenprodTokenGenerateResponse.
    /// </summary>
    public class AlipayInsSceneOpenprodTokenGenerateResponse : AopResponse
    {
        /// <summary>
        /// 过期时间，格式为'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 加密后的身份Token，解密后包含用户真实姓名（realName）、手机号（phone）、身份证号（idCardNo）及 Token 过期时间（expireTime）四要素，均为明文。无需脱敏的原因：该 Token 采用 AES-256 加密传输，仅持有密钥的授权方（insassetprod）可解密还原；
        /// </summary>
        [XmlElement("identity_token")]
        public string IdentityToken { get; set; }
    }
}
