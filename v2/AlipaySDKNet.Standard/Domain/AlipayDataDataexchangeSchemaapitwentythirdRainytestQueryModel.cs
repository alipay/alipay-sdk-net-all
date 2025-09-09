using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSchemaapitwentythirdRainytestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSchemaapitwentythirdRainytestQueryModel : AopObject
    {
        /// <summary>
        /// 1.1版本新增的 测试数据
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 测试数据，匿名复杂类型示例
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesRefWeakFifth DemoRef { get; set; }

        /// <summary>
        /// 测试数据，强引用复杂类型示例
        /// </summary>
        [XmlElement("demo_strong_ref")]
        public RainyComplexTypesTheThirteen DemoStrongRef { get; set; }

        /// <summary>
        /// 新增的测试数据
        /// </summary>
        [XmlElement("demo_vv_ref")]
        public RainyComplexTypesTheFourteen DemoVvRef { get; set; }

        /// <summary>
        /// 测试数据，弱引用复杂类型示例
        /// </summary>
        [XmlElement("demo_wink_ref")]
        public RainyComplexTypesTheFourteenOne DemoWinkRef { get; set; }
    }
}
