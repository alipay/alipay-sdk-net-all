using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeComplextypefirstRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeComplextypefirstRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 新创建的
        /// </summary>
        [XmlElement("schema_response_01")]
        public RainyComplexTypesRefWeakFirst SchemaResponse01 { get; set; }

        /// <summary>
        /// 引用已有的复杂类型
        /// </summary>
        [XmlElement("schema_response_02")]
        public RainyComplexTypesTheFirst SchemaResponse02 { get; set; }
    }
}
