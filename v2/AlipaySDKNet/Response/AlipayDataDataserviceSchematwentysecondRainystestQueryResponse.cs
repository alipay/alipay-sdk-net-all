using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchematwentysecondRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchematwentysecondRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// 出参测试数据
        /// </summary>
        [XmlElement("firstlevel_ref")]
        public RainyComplexTypesTheFourth FirstlevelRef { get; set; }

        /// <summary>
        /// 测试数据，第一层的N选一
        /// </summary>
        [XmlElement("firstlevel_string_1")]
        public string FirstlevelString1 { get; set; }

        /// <summary>
        /// 测试数据，第一层的N选一
        /// </summary>
        [XmlElement("firstlevel_string_2")]
        public string FirstlevelString2 { get; set; }
    }
}
