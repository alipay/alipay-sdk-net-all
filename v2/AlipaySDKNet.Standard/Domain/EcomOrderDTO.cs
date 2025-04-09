using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomOrderDTO : AopObject
    {
        /// <summary>
        /// 实际支付金额，单位：分
        /// </summary>
        [XmlElement("actual_pay_fee")]
        public long ActualPayFee { get; set; }

        /// <summary>
        /// 订单属性标
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("buy_amount")]
        public long BuyAmount { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 充电时长，分钟维度
        /// </summary>
        [XmlElement("charge_duration")]
        public InsPeriodDTO ChargeDuration { get; set; }

        /// <summary>
        /// 充电保障方案类型 (FREQUENCY/MONTH/YEAR)为空时默认为FREQUENCY
        /// </summary>
        [XmlElement("charge_guarantee_plan_type")]
        public string ChargeGuaranteePlanType { get; set; }

        /// <summary>
        /// 免押金额，单位：分
        /// </summary>
        [XmlElement("credit_deposit_money")]
        public long CreditDepositMoney { get; set; }

        /// <summary>
        /// 优惠金额，单位：分
        /// </summary>
        [XmlElement("discount_fee")]
        public long DiscountFee { get; set; }

        /// <summary>
        /// 驾驶人列表
        /// </summary>
        [XmlArray("drivers")]
        [XmlArrayItem("ins_open_user_d_t_o")]
        public List<InsOpenUserDTO> Drivers { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("item_pict_url")]
        public string ItemPictUrl { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("item_price")]
        public long ItemPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品总价值，单位：分
        /// </summary>
        [XmlElement("item_total_value")]
        public long ItemTotalValue { get; set; }

        /// <summary>
        /// 行程列表
        /// </summary>
        [XmlElement("itineraries")]
        public InsTransportItineraryDTO Itineraries { get; set; }

        /// <summary>
        /// 出租人
        /// </summary>
        [XmlElement("leaser")]
        public InsOpenUserDTO Leaser { get; set; }

        /// <summary>
        /// 物流单
        /// </summary>
        [XmlElement("logistics_order")]
        public EcomLogisticsOrderDTO LogisticsOrder { get; set; }

        /// <summary>
        /// 主订单id
        /// </summary>
        [XmlElement("main_order_id")]
        public string MainOrderId { get; set; }

        /// <summary>
        /// 订单结束时间
        /// </summary>
        [XmlElement("order_end_time")]
        public string OrderEndTime { get; set; }

        /// <summary>
        /// 订单金额,单位：分
        /// </summary>
        [XmlElement("order_fee")]
        public long OrderFee { get; set; }

        /// <summary>
        /// 订单id，必填
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单开始时间
        /// </summary>
        [XmlElement("order_start_time")]
        public string OrderStartTime { get; set; }

        /// <summary>
        /// 订单类型：MAIN_AND_DETAIL（主子一体订单）, MAIN（主订单）,DETAIL（子订单）
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 支付单
        /// </summary>
        [XmlElement("pay_order")]
        public PayOrderDTO PayOrder { get; set; }

        /// <summary>
        /// 邮费,单位：分
        /// </summary>
        [XmlElement("post_fee")]
        public long PostFee { get; set; }

        /// <summary>
        /// 订单商家物流寄件方式
        /// </summary>
        [XmlElement("post_type")]
        public string PostType { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 子订单列表
        /// </summary>
        [XmlArray("sub_order_list")]
        [XmlArrayItem("ecom_sub_order_d_t_o")]
        public List<EcomSubOrderDTO> SubOrderList { get; set; }

        /// <summary>
        /// 交易天数
        /// </summary>
        [XmlElement("trade_days")]
        public long TradeDays { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [XmlElement("trade_end_time")]
        public string TradeEndTime { get; set; }

        /// <summary>
        /// 交易图片
        /// </summary>
        [XmlArray("trade_pictures")]
        [XmlArrayItem("string")]
        public List<string> TradePictures { get; set; }

        /// <summary>
        /// 交易开始时间
        /// </summary>
        [XmlElement("trade_start_time")]
        public string TradeStartTime { get; set; }
    }
}
