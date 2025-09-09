using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeSchemaapitwentythirdRainytestQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeSchemaapitwentythirdRainytestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据，匿名复杂类型示例
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesRefWeakFifth DemoRef { get; set; }

        /// <summary>
        /// 1.1版本新增的 测试数据
        /// </summary>
        [XmlElement("demo_res")]
        public string DemoRes { get; set; }

        /// <summary>
        /// 测试数据，强引用复杂类型示例
        /// </summary>
        [XmlElement("demo_strong_ref")]
        public RainyComplexTypesTheThirteen DemoStrongRef { get; set; }

        /// <summary>
        /// 测试数据，弱引用复杂类型示例
        /// </summary>
        [XmlElement("demo_wink_ref")]
        public RainyComplexTypesTheFourteenOne DemoWinkRef { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("test")]
        public RainyComplexTypesTheThirteen Test { get; set; }
    }
}
