using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamedeliverRtaQueryResponse.
    /// </summary>
    public class AlipayUserGamedeliverRtaQueryResponse : AopResponse
    {
        /// <summary>
        /// true-参竞 false-不参竞
        /// </summary>
        [XmlElement("bid_decision")]
        public bool BidDecision { get; set; }
    }
}
