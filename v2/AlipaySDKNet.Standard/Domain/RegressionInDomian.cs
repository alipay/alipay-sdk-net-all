using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegressionInDomian Data Structure.
    /// </summary>
    [Serializable]
    public class RegressionInDomian : AopObject
    {
        /// <summary>
        /// a下普通字段a
        /// </summary>
        [XmlElement("a_test_a")]
        public string ATestA { get; set; }

        /// <summary>
        /// fasf
        /// </summary>
        [XmlElement("bb")]
        public string Bb { get; set; }

        /// <summary>
        /// sdfs
        /// </summary>
        [XmlElement("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// asfa
        /// </summary>
        [XmlElement("input_b")]
        public bool InputB { get; set; }
    }
}
