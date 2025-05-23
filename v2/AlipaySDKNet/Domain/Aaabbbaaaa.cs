using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Aaabbbaaaa Data Structure.
    /// </summary>
    [Serializable]
    public class Aaabbbaaaa : AopObject
    {
        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("aaaa")]
        public AddressInfo Aaaa { get; set; }

        /// <summary>
        /// 2222
        /// </summary>
        [XmlElement("bbbb")]
        public string Bbbb { get; set; }
    }
}
