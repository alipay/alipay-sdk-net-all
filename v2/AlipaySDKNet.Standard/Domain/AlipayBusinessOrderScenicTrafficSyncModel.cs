using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessOrderScenicTrafficSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderScenicTrafficSyncModel : AopObject
    {
        /// <summary>
        /// 订单金额 举例： 如果门票100，商户自己学生票打8折，那就收80，支付宝交易里的金额是80。 然后支付宝正好有活动，立减5块钱，最后用户付了75。针对这个场景： amount：100.00； discount_amount：20.00 pay_amount：80.00
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 下单小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 景区交通小程序id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlElement("contact")]
        public ScenicTrafficUserInfo Contact { get; set; }

        /// <summary>
        /// 优惠金额，仅包含商户优惠的金额。
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 扩展信息【废弃】
        /// </summary>
        [XmlElement("ext_info")]
        public ScenicExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 扩展信息。回流的key值请提前联系支付宝侧人员配置，否则回流的key值不会被消费
        /// </summary>
        [XmlArray("ext_infos")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// open_id是用户（UserId）在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单创建时间，该值不可变。
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 行业侧的订单id，该字段可选，具体描述分如下场景： 1.若订单是第一次同步，即新增场景，此时无需传该字段。订单同步成功后，在返回值中会将该字段给到isv。 2.若订单不是第一次同步，即更新场景，此时一定要传该字段。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单链接。注意需对page=后面的内容encode
        /// </summary>
        [XmlElement("order_link")]
        public string OrderLink { get; set; }

        /// <summary>
        /// 订单更新时间。
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单付款时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单来源isv
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// WAIT_PAY  待支付， PAID 支付成功， IN_THE_TICKET 出票中， TICKETED 出票成功， UN_TICKET 出票失败， WAITING_CHECK 待检票， CHECK_IN 已检票， REFUNDING 申请退票中， REFUNDED 已退票。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// isv侧订单id
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// ALIPAY("ALIPAY","支付宝")
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 退票金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// REFUND_AUDITING 退票审核中,  REFUND_SUCCESS 已退票,  REFUND_FAILURE 退票失败。
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退票数量
        /// </summary>
        [XmlElement("refund_ticket_num")]
        public string RefundTicketNum { get; set; }

        /// <summary>
        /// 退票时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 票务信息。 最大长度限制为10，超出部分不会被消费
        /// </summary>
        [XmlArray("ticket_info")]
        [XmlArrayItem("scenic_traffic_ticket_info")]
        public List<ScenicTrafficTicketInfo> TicketInfo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单下单用户支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
