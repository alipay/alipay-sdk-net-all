using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceSchemacreattestRainystestQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceSchemacreattestRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case_res")]
        public string DemoCaseRes { get; set; }
    }
}
