using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapseventeenthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapseventeenthRainystestQueryResponse : AopResponse
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
