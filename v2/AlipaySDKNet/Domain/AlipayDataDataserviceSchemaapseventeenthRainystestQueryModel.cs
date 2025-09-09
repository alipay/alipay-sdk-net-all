using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapseventeenthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapseventeenthRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 匿名复杂类型
        /// </summary>
        [XmlElement("demo_ref")]
        public RainysComplexRefFirst DemoRef { get; set; }

        /// <summary>
        /// 弱引用
        /// </summary>
        [XmlElement("demo_weak_ref")]
        public RainysComplexRefSecond DemoWeakRef { get; set; }
    }
}
