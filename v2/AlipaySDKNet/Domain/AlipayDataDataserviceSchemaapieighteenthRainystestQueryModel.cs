using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapieighteenthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapieighteenthRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 匿名复杂类型
        /// </summary>
        [XmlElement("demo_object_1")]
        public RainysComplexRefForth DemoObject1 { get; set; }

        /// <summary>
        /// 弱引用
        /// </summary>
        [XmlElement("demo_weak")]
        public RainysComplexRefFifth DemoWeak { get; set; }
    }
}
