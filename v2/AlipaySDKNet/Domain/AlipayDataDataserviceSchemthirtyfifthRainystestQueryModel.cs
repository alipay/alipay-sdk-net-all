using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemthirtyfifthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemthirtyfifthRainystestQueryModel : AopObject
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
