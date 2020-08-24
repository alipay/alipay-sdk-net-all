using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayGongyiAddressTest Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayGongyiAddressTest : AopObject
    {
        /// <summary>
        /// 航海走
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 中国
        /// </summary>
        [XmlElement("contury")]
        public string Contury { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }
    }
}
