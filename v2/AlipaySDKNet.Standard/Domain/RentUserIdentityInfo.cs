using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentUserIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentUserIdentityInfo : AopObject
    {
        /// <summary>
        /// 加密的用户身份信息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用户身份信息安全密钥，用于对content进行解密
        /// </summary>
        [XmlElement("secure_key")]
        public string SecureKey { get; set; }
    }
}
