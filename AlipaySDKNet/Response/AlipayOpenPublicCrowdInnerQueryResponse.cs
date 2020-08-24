using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicCrowdInnerQueryResponse.
    /// </summary>
    public class AlipayOpenPublicCrowdInnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群摘要信息
        /// </summary>
        [XmlElement("crowd_summary")]
        public CrowdSummary CrowdSummary { get; set; }
    }
}
