using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignUrlResult Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignUrlResult : AopObject
    {
        /// <summary>
        /// 加密后的签署方证件号(用来关联签署方的签署链接)
        /// </summary>
        [XmlElement("encrypt_sign_cert_no")]
        public string EncryptSignCertNo { get; set; }

        /// <summary>
        /// 签署方名称
        /// </summary>
        [XmlElement("sign_cert_name")]
        public string SignCertName { get; set; }

        /// <summary>
        /// 签署方证件号（脱敏）
        /// </summary>
        [XmlElement("sign_cert_no")]
        public string SignCertNo { get; set; }

        /// <summary>
        /// 签署链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }

        /// <summary>
        /// 签署方id
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }
    }
}
