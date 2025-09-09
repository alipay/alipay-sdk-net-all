using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapisixteenthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapisixteenthRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 匿名复杂类型
        /// </summary>
        [XmlElement("demo_object")]
        public RainysComplexRefThird DemoObject { get; set; }

        /// <summary>
        /// 强引用
        /// </summary>
        [XmlElement("demo_weak")]
        public RainyComplexTypesTheEighth DemoWeak { get; set; }
    }
}
