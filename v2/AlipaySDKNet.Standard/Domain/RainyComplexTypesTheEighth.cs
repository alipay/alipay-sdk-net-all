using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheEighth Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheEighth : AopObject
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("case_string")]
        public string CaseString { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }
    }
}
