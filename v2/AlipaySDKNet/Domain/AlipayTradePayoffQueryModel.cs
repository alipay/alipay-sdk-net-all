using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePayoffQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePayoffQueryModel : AopObject
    {
        /// <summary>
        /// bbb
        /// </summary>
        [XmlElement("bbb")]
        public string Bbb { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [XmlElement("ccc")]
        public string Ccc { get; set; }
    }
}
