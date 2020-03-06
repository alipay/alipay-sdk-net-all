using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiProvisioningBundle Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiProvisioningBundle : AopObject
    {
        /// <summary>
        /// 加密后的数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 一次性公密钥
        /// </summary>
        [XmlElement("ephemeral_public_key")]
        public string EphemeralPublicKey { get; set; }

        /// <summary>
        /// 公钥hash
        /// </summary>
        [XmlElement("public_key_hash")]
        public string PublicKeyHash { get; set; }

        /// <summary>
        /// EC_v2
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }
    }
}
