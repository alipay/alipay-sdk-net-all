using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapififteenthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapififteenthRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_res")]
        public string DemoRes { get; set; }
    }
}
