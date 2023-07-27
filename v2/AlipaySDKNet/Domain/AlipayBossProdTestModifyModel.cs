using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdTestModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdTestModifyModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_copy")]
        public PublicComplex ComplexCopy { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_copy_2")]
        public PublicComplexWzw ComplexCopy2 { get; set; }

        /// <summary>
        /// tet
        /// </summary>
        [XmlElement("complex_ref")]
        public PublicComplex ComplexRef { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_boolean")]
        public bool TestBoolean { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_date")]
        public string TestDate { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_number")]
        public long TestNumber { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_number_2")]
        public long TestNumber2 { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_price")]
        public string TestPrice { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("test_string_open_ids")]
        [XmlArrayItem("string")]
        public List<string> TestStringOpenIds { get; set; }
    }
}
