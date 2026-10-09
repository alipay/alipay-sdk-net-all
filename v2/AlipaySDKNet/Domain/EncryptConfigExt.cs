using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EncryptConfigExt Data Structure.
    /// </summary>
    [Serializable]
    public class EncryptConfigExt : AopObject
    {
        /// <summary>
        /// APPID
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }

        /// <summary>
        /// 加密类型
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }
    }
}
