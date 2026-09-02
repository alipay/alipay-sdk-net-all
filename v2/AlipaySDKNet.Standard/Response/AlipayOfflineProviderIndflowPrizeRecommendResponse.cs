using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderIndflowPrizeRecommendResponse.
    /// </summary>
    public class AlipayOfflineProviderIndflowPrizeRecommendResponse : AopResponse
    {
        /// <summary>
        /// 推荐奖品详情
        /// </summary>
        [XmlElement("recommend_prizes")]
        public AdVoucherPrizeDetail RecommendPrizes { get; set; }

        /// <summary>
        /// 发奖记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
