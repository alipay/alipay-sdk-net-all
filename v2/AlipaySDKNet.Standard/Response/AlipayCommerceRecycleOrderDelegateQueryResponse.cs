using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderDelegateQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单基础信息
        /// </summary>
        [XmlElement("order_base")]
        public RecycleStdOrderBaseVO OrderBase { get; set; }

        /// <summary>
        /// 订单履约信息
        /// </summary>
        [XmlElement("order_delivery")]
        public RecycleDeliveryVO OrderDelivery { get; set; }

        /// <summary>
        /// 品牌膨胀金信息
        /// </summary>
        [XmlElement("order_fund_subsidy")]
        public RecycleStdOrderFundSubSidyVO OrderFundSubsidy { get; set; }

        /// <summary>
        /// 回收商户信息
        /// </summary>
        [XmlElement("order_merchant")]
        public RecycleStdOrderMerchantInfoVO OrderMerchant { get; set; }

        /// <summary>
        /// 订单退货信息
        /// </summary>
        [XmlElement("order_sendback")]
        public RecycleDeliveryVO OrderSendback { get; set; }
    }
}
