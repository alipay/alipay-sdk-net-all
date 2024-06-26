using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOrderDataOpenapiResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOrderDataOpenapiResultInfo : AopObject
    {
        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务号列表  注：biz_type目前仅支持"TRADE_NO"
        /// </summary>
        [XmlArray("biz_no_list")]
        [XmlArrayItem("string")]
        public List<string> BizNoList { get; set; }

        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 总的订单优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 具体已开放平台文档为准，若无，则目前不存在扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单支付时间  若订单还未支付，则该字段为空
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_order_info_result")]
        public List<ItemOrderInfoResult> ItemList { get; set; }

        /// <summary>
        /// 订单物流信息列表
        /// </summary>
        [XmlArray("logistics_info_list")]
        [XmlArrayItem("order_logistics_information")]
        public List<OrderLogisticsInformation> LogisticsInfoList { get; set; }

        /// <summary>
        /// 商户订单业务类型
        /// </summary>
        [XmlElement("merchant_biz_type")]
        public string MerchantBizType { get; set; }

        /// <summary>
        /// 商户订单链接地址
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 外部订单号 out_biz_no唯一对应一笔订单
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户的uid，即所需查询订单的partnerId
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// OpenId是用户在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝小程序订单详情地址链接
        /// </summary>
        [XmlElement("order_detail_link_page")]
        public string OrderDetailLinkPage { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态  PAID-已支付  MERCHANT_CONFIRMED-已确认  MERCHENT_SERVICING-服务中  MERCHANT_DELIVERD-已发货  MERCHANT_FINISHED-服务完成  REFUNDED-已退款
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型，SERVICE_ORDER：服务订单 -TRADE_ORDER：交易订单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户前置额外费用
        /// </summary>
        [XmlElement("pre_cost")]
        public PreAmountInfoResult PreCost { get; set; }

        /// <summary>
        /// 商户前置营销优惠
        /// </summary>
        [XmlElement("pre_promotion")]
        public PreAmountInfoResult PrePromotion { get; set; }

        /// <summary>
        /// 买家实付金额
        /// </summary>
        [XmlElement("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public OrderShopInfoResult ShopInfo { get; set; }

        /// <summary>
        /// 凭证信息
        /// </summary>
        [XmlElement("ticket_info")]
        public TicketInfoResult TicketInfo { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 小程序应用logo
        /// </summary>
        [XmlElement("tiny_app_logo")]
        public string TinyAppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("tiny_app_name")]
        public string TinyAppName { get; set; }
    }
}
