using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询过滤条件, 单品券goods_id.  由于是列表, 单次限制最多5
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
        /// 是否只查询当前ISV代报名的活动
        /// </summary>
        [XmlElement("only_current_isv")]
        public bool OnlyCurrentIsv { get; set; }

        /// <summary>
        /// 分页器
        /// </summary>
        [XmlElement("paginator")]
        public Paginator Paginator { get; set; }
    }
}
