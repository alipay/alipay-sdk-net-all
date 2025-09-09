using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceTreeapitenthRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceTreeapitenthRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }
    }
}
