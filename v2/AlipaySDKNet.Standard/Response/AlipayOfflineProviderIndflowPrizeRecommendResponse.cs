using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderIndflowPrizeRecommendResponse.
    /// </summary>
    public class AlipayOfflineProviderIndflowPrizeRecommendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("recommend_prizes")]
        [XmlArrayItem("ad_voucher_prize_detail")]
        public List<AdVoucherPrizeDetail> RecommendPrizes { get; set; }

        /// <summary>
        /// 发奖记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
