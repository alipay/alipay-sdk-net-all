using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolXuanyitestQueryResponse.
    /// </summary>
    public class AlipayMarketingToolXuanyitestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试用的
        /// </summary>
        [XmlElement("test_100")]
        public string Test100 { get; set; }

        /// <summary>
        /// 测试2
        /// </summary>
        [XmlElement("test_101")]
        public bool Test101 { get; set; }
    }
}
