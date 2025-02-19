using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapithirdteethRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapithirdteethRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_response")]
        public string DemoResponse { get; set; }
    }
}
