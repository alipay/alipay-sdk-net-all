using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAntestReportQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试报告页url
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
