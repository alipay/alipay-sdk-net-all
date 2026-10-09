using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapisixteenthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapisixteenthRainystestQueryResponse : AopResponse
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
