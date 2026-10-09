using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppBainaPrizeQueryResponse.
    /// </summary>
    public class AlipayPayAppBainaPrizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户兑奖资格数量
        /// </summary>
        [XmlElement("eligible_count")]
        public long EligibleCount { get; set; }
    }
}
