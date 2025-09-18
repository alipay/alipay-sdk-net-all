using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleMarketingOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleMarketingOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 推广订单信息
        /// </summary>
        [XmlElement("promotion_order_info")]
        public MarketingPromotionOrderInfo PromotionOrderInfo { get; set; }
    }
}
