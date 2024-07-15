using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIsponetestWzwtestWzwtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIsponetestWzwtestWzwtestQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [XmlElement("aaaa")]
        public string Aaaa { get; set; }

        /// <summary>
        /// 33 当前字段已废弃(dddddddddd)
        /// </summary>
        [XmlElement("bbbb")]
        public string Bbbb { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("ccc")]
        public string Ccc { get; set; }

        /// <summary>
        /// test 当前字段已废弃(test废弃字段测试)
        /// </summary>
        [XmlElement("complex_a")]
        public TestDemo ComplexA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_b")]
        public string ComplexB { get; set; }

        /// <summary>
        /// test 当前字段已废弃(test废弃原因测试)
        /// </summary>
        [XmlElement("string_a")]
        public string StringA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("string_b")]
        public string StringB { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("uid_a")]
        public string UidA { get; set; }
    }
}
