using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheFirstFouth Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheFirstFouth : AopObject
    {
        /// <summary>
        /// 第五层
        /// </summary>
        [XmlElement("fifth_level")]
        public RainyComplexTypesTheFirst FifthLevel { get; set; }

        /// <summary>
        /// 第四层布尔参数
        /// </summary>
        [XmlElement("fouth_level_boolean")]
        public bool FouthLevelBoolean { get; set; }

        /// <summary>
        /// 第四层数值c参数
        /// </summary>
        [XmlElement("fouth_level_num")]
        public long FouthLevelNum { get; set; }

        /// <summary>
        /// 第四层有正则的参数
        /// </summary>
        [XmlElement("fouth_level_string")]
        public string FouthLevelString { get; set; }

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
    }
}
