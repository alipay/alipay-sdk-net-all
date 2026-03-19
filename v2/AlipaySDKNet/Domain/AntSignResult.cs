using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignResult Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignResult : AopObject
    {
        /// <summary>
        /// 企业直签链接
        /// </summary>
        [XmlElement("cert_sign_url")]
        public string CertSignUrl { get; set; }

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
        /// 签署链接：电子签任务为异步任务，请确保已处于签署中（SIGNNING）状态，再给用户发送签署链接，否则用户签署会不成功
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
