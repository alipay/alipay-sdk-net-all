using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("market_activity_info")]
        public List<MarketActivityInfo> Activities { get; set; }

        /// <summary>
        /// 分页器
        /// </summary>
        [XmlElement("paginator")]
        public Paginator Paginator { get; set; }
    }
}
