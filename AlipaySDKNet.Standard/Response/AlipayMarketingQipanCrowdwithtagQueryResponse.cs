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
        /// 人群数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }
    }
}
