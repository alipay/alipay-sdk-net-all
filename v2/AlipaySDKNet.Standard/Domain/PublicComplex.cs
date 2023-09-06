using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicComplex Data Structure.
    /// </summary>
    [Serializable]
    public class PublicComplex : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_testa")]
        public PublicComplexWzw ComplexTesta { get; set; }

        /// <summary>
        /// 1test
        /// </summary>
        [XmlArray("test_boolean")]
        [XmlArrayItem("boolean")]
        public List<bool> TestBoolean { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_date")]
        public string TestDate { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_new")]
        public string TestNew { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("test_number")]
        [XmlArrayItem("number")]
        public List<long> TestNumber { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("test_price")]
        [XmlArrayItem("price")]
        public List<string> TestPrice { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_string_open_id")]
        public string TestStringOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("update_test")]
        public string UpdateTest { get; set; }
    }
}
