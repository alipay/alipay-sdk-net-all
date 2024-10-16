using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardOrderBatchQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CardOrderBatchQueryResponse : AopObject
    {
        /// <summary>
        /// 售卖订单的余额面额，单位分
        /// </summary>
        [XmlElement("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// 安心付绑卡信息
        /// </summary>
        [XmlElement("axf_card_bind_info")]
        public AxfCardBindInfo AxfCardBindInfo { get; set; }

        /// <summary>
        /// 用于区分订购单的取消类型
        /// </summary>
        [XmlElement("cancel_type")]
        public string CancelType { get; set; }

        /// <summary>
        /// 已解约金额，单位：分
        /// </summary>
        [XmlElement("cancelled_cash")]
        public long CancelledCash { get; set; }

        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// （1）TIMES_CARD / PERIOD_PAY / AXF_MERCHANT_PERIOD_PAY / AXF_MERCHANT_PERIOD_PAY_INDIRECT： init、available、used_up、closing、closed、pause （2）AXF_MONEY_CARD：available、invalid、paid、refund、timeout_closed、used_up （3）AXF_MONEY_TIME_CARD：wait_pay、paid、available、timeout_closed、used_up、invalid、closing
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 追回优惠金额，包含退款金额，单位：分
        /// </summary>
        [XmlElement("discount_cash")]
        public long DiscountCash { get; set; }

        /// <summary>
        /// 计划追回优惠金额，单位：分
        /// </summary>
        [XmlElement("discount_plan_cash")]
        public long DiscountPlanCash { get; set; }

        /// <summary>
        /// 追回金额--已退金额，单位：分
        /// </summary>
        [XmlElement("discount_refund_cash")]
        public long DiscountRefundCash { get; set; }

        /// <summary>
        /// 订单有效期开始时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 订单有效期结束时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 购卡时的卡名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户购卡时的卡原价，单位分
        /// </summary>
        [XmlElement("origin_price_total")]
        public long OriginPriceTotal { get; set; }

        /// <summary>
        /// 商户在跳转购卡页时的自定义外部单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [XmlElement("refund_cash")]
        public long RefundCash { get; set; }

        /// <summary>
        /// 剩余期数(次数)
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }

        /// <summary>
        /// 用户购卡时的卡售价，单位分
        /// </summary>
        [XmlElement("sale_price_total")]
        public long SalePriceTotal { get; set; }

        /// <summary>
        /// 购卡时的门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 总期数(次数)
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// （1）金额卡余额现金价值，单位分 （2）周期卡未核销金额
        /// </summary>
        [XmlElement("usable_cash")]
        public long UsableCash { get; set; }

        /// <summary>
        /// 已核销金额，单位：分
        /// </summary>
        [XmlElement("used_cash")]
        public long UsedCash { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 脱敏后的用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户电话，用户授权后才有值
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
