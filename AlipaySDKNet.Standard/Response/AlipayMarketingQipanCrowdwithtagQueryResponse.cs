using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQipanCrowdwithtagQueryResponse.
    /// </summary>
    public class AlipayMarketingQipanCrowdwithtagQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群数量-暂不支持
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 人群规模
        /// </summary>
        [XmlElement("count_range")]
        public string CountRange { get; set; }
    }
}
