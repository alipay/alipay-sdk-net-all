using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdTestAproveModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdTestAproveModifyModel : AopObject
    {
        /// <summary>
        /// tet
        /// </summary>
        [XmlElement("complex_copy")]
        public PublicComplex ComplexCopy { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_ref")]
        public PublicComplex ComplexRef { get; set; }

        /// <summary>
        /// test 当前字段已废弃(test废弃原因测试)
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

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
    }
}
