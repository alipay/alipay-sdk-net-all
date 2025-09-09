using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapininteenthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapininteenthRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 匿名复杂类型
        /// </summary>
        [XmlElement("demo_object_1")]
        public RainysComplexRefSixth DemoObject1 { get; set; }

        /// <summary>
        /// 强引用
        /// </summary>
        [XmlElement("demo_strong")]
        public RainyComplexTypesTheNinth DemoStrong { get; set; }

        /// <summary>
        /// 弱引用
        /// </summary>
        [XmlElement("demo_weak")]
        public RainysComplexRefSeventh DemoWeak { get; set; }
    }
}
