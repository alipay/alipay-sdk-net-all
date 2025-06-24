using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemthirtyfifthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemthirtyfifthRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesTheThirteen DemoRef { get; set; }

        /// <summary>
        /// 测试数据，无需关注；
        /// </summary>
        [XmlElement("demo_str_1")]
        public string DemoStr1 { get; set; }

        /// <summary>
        /// 测试数据，无需关注；
        /// </summary>
        [XmlElement("demo_str_2")]
        public string DemoStr2 { get; set; }
    }
}
