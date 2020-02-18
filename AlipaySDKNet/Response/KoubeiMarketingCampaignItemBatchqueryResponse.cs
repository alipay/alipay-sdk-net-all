using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回商品券集合信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("promo_item_info")]
        public List<PromoItemInfo> Items { get; set; }
    }
}
