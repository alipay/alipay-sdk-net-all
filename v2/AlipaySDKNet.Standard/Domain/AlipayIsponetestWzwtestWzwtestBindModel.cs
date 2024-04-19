using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIsponetestWzwtestWzwtestBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIsponetestWzwtestWzwtestBindModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_1")]
        public TestDemoWzw Complex1 { get; set; }

        /// <summary>
        /// Number_c
        /// </summary>
        [XmlElement("number_c")]
        public long NumberC { get; set; }

        /// <summary>
        /// number_d
        /// </summary>
        [XmlElement("number_d")]
        public long NumberD { get; set; }

        /// <summary>
        /// sss
        /// </summary>
        [XmlElement("string")]
        public string String { get; set; }

        /// <summary>
        /// string_a
        /// </summary>
        [XmlElement("string_a")]
        public string StringA { get; set; }

        /// <summary>
        /// string_b
        /// </summary>
        [XmlElement("string_b")]
        public string StringB { get; set; }
    }
}
