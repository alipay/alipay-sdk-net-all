using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessPublicKey Data Structure.
    /// </summary>
    [Serializable]
    public class AccessPublicKey : AopObject
    {
        /// <summary>
        /// 公钥id
        /// </summary>
        [XmlElement("key_id")]
        public long KeyId { get; set; }

        /// <summary>
        /// 公钥内容
        /// </summary>
        [XmlElement("public_key")]
        public string PublicKey { get; set; }
    }
}
