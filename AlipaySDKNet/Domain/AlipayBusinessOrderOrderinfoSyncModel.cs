using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessOrderOrderinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderOrderinfoSyncModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 下单用户
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlArray("contact")]
        [XmlArrayItem("contact")]
        public List<Contact> Contact { get; set; }

        /// <summary>
        /// 打折金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 订单属性 FORWARD("FORWARD", "提前购"), DAY("DAY","当日购")
        /// </summary>
        [XmlElement("order_character")]
        public string OrderCharacter { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 支付宝行业订单id  新建时为null， 更新时必传，和出参中object_id一致
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝小程序订单详情页链接
        /// </summary>
        [XmlElement("order_link")]
        public string OrderLink { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单状态 CHECK_WAITING("CHECK_WAITING",待检票)， CHECKED("CHECKED",已检票)， FINISHED("FINISHED",已完结)， TICKET_RUNNING("TICKET_RUNNING",出票中)， PAY_WAITING("PAY_WAITING",待付款)， REFUND_AUDITING("REFUND_AUDITING",退单审核中)， REFUND_SUCCESS("REFUND_SUCCESS",已退单)， CLOSED("CLOSED",已关闭), REFUND_RUNNING("REFUND_RUNNING","退单中")
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型 TICKET("TICKET","门票订单")
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 订单外部id
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// app下标识一个景区的景区id
        /// </summary>
        [XmlElement("outer_scenic_id")]
        public string OuterScenicId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// Passengers
        /// </summary>
        [XmlArray("passengers")]
        [XmlArrayItem("passengers")]
        public List<Passengers> Passengers { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 具体付款方式 ALIPAY("ALIPAY","支付宝"), MEMBERSHIP_CARD("MEMBERSHIP_CARD","会员卡支付"), BALANCE("BALANCE","余额"), WECHAT("WECHAT","微信")
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 支付状态 WAITING("WAITING",待支付)， SUCCESS("SUCCESS",支付成功)， FAILURE("FAILURE",支付失败)， REFUND_WAITING("REFUND_WAITING",待退款)， REFUND_SUCCESS("REFUND_SUCCESS",已退款)， REFUND_FAILURE("REFUND_FAILURE",退款失败)
        /// </summary>
        [XmlElement("payment_status")]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// 退票金额
        /// </summary>
        [XmlElement("refund_amout")]
        public string RefundAmout { get; set; }

        /// <summary>
        /// 退票数量
        /// </summary>
        [XmlElement("refund_count")]
        public string RefundCount { get; set; }

        /// <summary>
        /// 退票手续费
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退票手续费类型 PERCENT("PERCENT","百分比"), FIXED("FIXED","固定值")
        /// </summary>
        [XmlElement("refund_fee_type")]
        public string RefundFeeType { get; set; }

        /// <summary>
        /// 退票状态 REFUND_AUDITING("REFUND_AUDITING",退票审核中), REFUND_SUCCESS("REFUND_SUCCESS",已退票), REFUND_FAILURE("REFUND_FAILURE",退票失败)
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退票时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 景区小程序id
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 购票来源 ALIPAY_MINI_APP("ALIPAY_MINI_APP", "支付宝小程序"), H5("H5", "H5")
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// ISV
        /// </summary>
        [XmlElement("source_system")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 门票
        /// </summary>
        [XmlArray("ticket_info")]
        [XmlArrayItem("scenic_ticket_info")]
        public List<ScenicTicketInfo> TicketInfo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 更新信息
        /// </summary>
        [XmlElement("update_msg")]
        public string UpdateMsg { get; set; }
    }
}
