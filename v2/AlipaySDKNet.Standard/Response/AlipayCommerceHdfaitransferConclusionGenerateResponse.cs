using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfaitransferConclusionGenerateResponse.
    /// </summary>
    public class AlipayCommerceHdfaitransferConclusionGenerateResponse : AopResponse
    {
        /// <summary>
        /// 问诊总结结果
        /// </summary>
        [XmlElement("conclusion_summary")]
        public string ConclusionSummary { get; set; }
    }
}
