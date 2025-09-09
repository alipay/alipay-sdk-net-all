using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceOnlineerrorRainyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceOnlineerrorRainyQueryModel : AopObject
    {
        /// <summary>
        /// 第五个复杂类型
        /// </summary>
        [XmlElement("complex_type_twice")]
        public RainyComplexTypesTheSecond ComplexTypeTwice { get; set; }

        /// <summary>
        /// 234
        /// </summary>
        [XmlElement("test_case_complex_input")]
        public RainyComplexTypesTheFirst TestCaseComplexInput { get; set; }

        /// <summary>
        /// 是否必选
        /// </summary>
        [XmlElement("test_case_is_must_input")]
        public string TestCaseIsMustInput { get; set; }
    }
}
