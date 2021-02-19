using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("marketing_activity_info")]
        public List<MarketingActivityInfo> ActivityList { get; set; }
    }
}
