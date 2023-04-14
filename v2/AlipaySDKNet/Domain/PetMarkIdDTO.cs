using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PetMarkIdDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PetMarkIdDTO : AopObject
    {
        /// <summary>
        /// encryptionMarkId md5 后的微信端唯一标识
        /// </summary>
        [XmlElement("encryption_mark_id")]
        public string EncryptionMarkId { get; set; }

        /// <summary>
        /// 微信端唯一标识
        /// </summary>
        [XmlElement("mark_id")]
        public string MarkId { get; set; }
    }
}
