using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 可领券的活动列表
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("market_activity_info")]
        public List<MarketActivityInfo> Activities { get; set; }
    }
}
