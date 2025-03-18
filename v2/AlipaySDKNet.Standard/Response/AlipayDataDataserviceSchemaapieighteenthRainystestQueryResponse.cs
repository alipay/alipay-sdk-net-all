using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapieighteenthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapieighteenthRainystestQueryResponse : AopResponse
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
