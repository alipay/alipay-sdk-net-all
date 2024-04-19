using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegressionPrivate Data Structure.
    /// </summary>
    [Serializable]
    public class RegressionPrivate : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("b")]
        public bool B { get; set; }

        /// <summary>
        /// sdfs
        /// </summary>
        [XmlElement("cc")]
        public long Cc { get; set; }
    }
}
