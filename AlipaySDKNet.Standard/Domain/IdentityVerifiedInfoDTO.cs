using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdentityVerifiedInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IdentityVerifiedInfoDTO : AopObject
    {
        /// <summary>
        /// MD5加密处理后的证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。暂仅支持 IDENTITY_CARD （身份证）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
