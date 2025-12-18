using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarAutoloanOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarAutoloanOrderSyncModel : AopObject
    {
        /// <summary>
        /// 业务状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 租购订单信息
        /// </summary>
        [XmlElement("leasing_order_info")]
        public CarLeasingOrder LeasingOrderInfo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 车生活订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家业务流水号，即商家订单多次业务变更的流水号，用于接口请求幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 订阅扣款信息
        /// </summary>
        [XmlElement("subscription_deduction_info")]
        public CarSubscriptionDeduction SubscriptionDeductionInfo { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("subscription_order_info")]
        public CarSubscriptionOrder SubscriptionOrderInfo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
