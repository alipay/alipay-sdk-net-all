using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapininteenthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapininteenthRainystestQueryModel : AopObject
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
