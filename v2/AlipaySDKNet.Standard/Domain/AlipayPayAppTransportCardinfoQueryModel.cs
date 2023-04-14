using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppTransportCardinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppTransportCardinfoQueryModel : AopObject
    {
        /// <summary>
        /// 具体查询的子命令
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }

        /// <summary>
        /// 加密信息密文
        /// </summary>
        [XmlElement("encoded_cipher")]
        public string EncodedCipher { get; set; }

        /// <summary>
        /// KMI密钥版本号
        /// </summary>
        [XmlElement("k_version")]
        public long KVersion { get; set; }

        /// <summary>
        /// 设备ID密文
        /// </summary>
        [XmlElement("tid_cipher")]
        public string TidCipher { get; set; }
    }
}
