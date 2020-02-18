using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 广告投放出去的商品信息
        /// </summary>
        [XmlArray("discounts")]
        [XmlArrayItem("discount_info")]
        public List<DiscountInfo> Discounts { get; set; }

        /// <summary>
        /// 券领取结果
        /// </summary>
        [XmlElement("purchase_datas")]
        public KbAdvertIdentifyResponse PurchaseDatas { get; set; }

        /// <summary>
        /// 本次推荐的唯一标识
        /// </summary>
        [XmlElement("recommend_id")]
        public string RecommendId { get; set; }
    }
}
