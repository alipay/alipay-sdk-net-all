using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheFirstTwo Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheFirstTwo : AopObject
    {
        /// <summary>
        /// 新增的而已
        /// </summary>
        [XmlElement("new_creat")]
        public string NewCreat { get; set; }

        /// <summary>
        /// 字符串的复杂类型拉
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

        /// <summary>
        /// boolean,V2版本改成可选；
        /// </summary>
        [XmlElement("test_b")]
        public bool TestB { get; set; }

        /// <summary>
        /// 第三次
        /// </summary>
        [XmlElement("third_level")]
        public RainyComplexTypesTheFirstThree ThirdLevel { get; set; }
    }
}
