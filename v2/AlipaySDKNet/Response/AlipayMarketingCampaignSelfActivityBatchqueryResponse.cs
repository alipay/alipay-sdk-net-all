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

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current_pages")]
        public string CurrentPages { get; set; }

        /// <summary>
        /// 每页活动数
        /// </summary>
        [XmlElement("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 返回总活动数
        /// </summary>
        [XmlElement("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }
    }
}
