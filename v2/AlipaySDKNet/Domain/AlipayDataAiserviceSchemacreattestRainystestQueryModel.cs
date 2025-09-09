using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceSchemacreattestRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceSchemacreattestRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }
    }
}
