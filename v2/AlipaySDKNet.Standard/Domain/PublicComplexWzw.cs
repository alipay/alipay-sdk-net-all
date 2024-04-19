using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicComplexWzw Data Structure.
    /// </summary>
    [Serializable]
    public class PublicComplexWzw : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_a")]
        public CorporateSealRectOpenVO ComplexA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("test_boolean")]
        [XmlArrayItem("boolean")]
        public List<bool> TestBoolean { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("test_number")]
        [XmlArrayItem("number")]
        public List<long> TestNumber { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_string_open_id")]
        public string TestStringOpenId { get; set; }
    }
}
