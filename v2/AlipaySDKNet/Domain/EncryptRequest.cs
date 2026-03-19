using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EncryptRequest Data Structure.
    /// </summary>
    [Serializable]
    public class EncryptRequest : AopObject
    {
        /// <summary>
        /// 加密参数
        /// </summary>
        [XmlElement("encrypted")]
        public string Encrypted { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
