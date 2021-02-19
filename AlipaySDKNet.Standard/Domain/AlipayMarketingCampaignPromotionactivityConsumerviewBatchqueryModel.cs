using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryModel : AopObject
    {
        /// <summary>
        /// 单品券场景下对应的goods_id,单次最多限制5个
        /// </summary>
        [XmlArray("goods_ids")]
        [XmlArrayItem("string")]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 是否只查询当前ISV报名的活动
        /// </summary>
        [XmlElement("only_current_isv")]
        public bool OnlyCurrentIsv { get; set; }
    }
}
