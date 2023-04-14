using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTesttestnumberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTesttestnumberQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public long A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("keykey")]
        public long Keykey { get; set; }
    }
}
