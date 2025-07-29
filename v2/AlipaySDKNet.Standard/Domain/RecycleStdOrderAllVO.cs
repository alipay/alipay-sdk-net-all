using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleStdOrderAllVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleStdOrderAllVO : AopObject
    {
        /// <summary>
        /// 订单基础
        /// </summary>
        [XmlElement("order_base")]
        public RecycleStdOrderBaseVO OrderBase { get; set; }

        /// <summary>
        /// 订单履约信息:工程师上门/邮寄/到店
        /// </summary>
        [XmlElement("order_delivery")]
        public RecycleDeliveryVO OrderDelivery { get; set; }

        /// <summary>
        /// 膨胀金信息
        /// </summary>
        [XmlElement("order_fund_subsidy")]
        public RecycleStdOrderFundSubSidyVO OrderFundSubsidy { get; set; }

        /// <summary>
        /// 回收商户的信息
        /// </summary>
        [XmlElement("order_merchant")]
        public RecycleStdOrderMerchantInfoVO OrderMerchant { get; set; }

        /// <summary>
        /// 订单退货信息（邮寄场景下，用户拒绝回收，会生成退货履约信息）
        /// </summary>
        [XmlElement("order_sendback")]
        public RecycleDeliveryVO OrderSendback { get; set; }
    }
}
