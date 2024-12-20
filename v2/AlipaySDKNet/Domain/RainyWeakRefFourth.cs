using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyWeakRefFourth Data Structure.
    /// </summary>
    [Serializable]
    public class RainyWeakRefFourth : AopObject
    {
        /// <summary>
        /// 新增的而已
        /// </summary>
        [XmlElement("new_creat")]
        public string NewCreat { get; set; }

        /// <summary>
        /// 价格单位 元
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
