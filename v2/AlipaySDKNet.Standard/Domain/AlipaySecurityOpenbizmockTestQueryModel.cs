using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityOpenbizmockTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityOpenbizmockTestQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlArray("complex")]
        [XmlArrayItem("public_complex")]
        public List<PublicComplex> Complex { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("test_boolean")]
        [XmlArrayItem("boolean")]
        public List<bool> TestBoolean { get; set; }

        /// <summary>
        /// ["2021-01-01"]
        /// </summary>
        [XmlArray("test_date")]
        [XmlArrayItem("date")]
        public List<string> TestDate { get; set; }

        /// <summary>
        /// [2,3]
        /// </summary>
        [XmlArray("test_number")]
        [XmlArrayItem("number")]
        public List<long> TestNumber { get; set; }

        /// <summary>
        /// [1.33,2.33]
        /// </summary>
        [XmlArray("test_price")]
        [XmlArrayItem("price")]
        public List<string> TestPrice { get; set; }

        /// <summary>
        /// string1
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// ["string1","string2"]
        /// </summary>
        [XmlArray("test_string_not_list")]
        [XmlArrayItem("string")]
        public List<string> TestStringNotList { get; set; }
    }
}
