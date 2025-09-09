using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdQingyongtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdQingyongtestQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("enum_2")]
        public string Enum2 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("enums")]
        public string Enums { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("key_id")]
        public string KeyId { get; set; }
    }
}
