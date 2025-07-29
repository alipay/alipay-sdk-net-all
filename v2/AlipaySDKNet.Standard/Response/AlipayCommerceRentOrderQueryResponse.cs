using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceRentOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentOrderReceiverAddressInfoVO AddressInfo { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 默认退货寄回地址
        /// </summary>
        [XmlElement("default_receiving_address")]
        public RentOrderReceiverAddressInfoVO DefaultReceivingAddress { get; set; }

        /// <summary>
        /// 订单履约信息
        /// </summary>
        [XmlElement("delivery_info")]
        public RentOrderDeliveryInfoVO DeliveryInfo { get; set; }

        /// <summary>
        /// 商品详细信息。当前只会有单个商品
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("rent_goods_detail_info_v_o")]
        public List<RentGoodsDetailInfoVO> ItemInfos { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 租赁订单页面地址信息
        /// </summary>
        [XmlElement("path_info")]
        public RentPathInfoVO PathInfo { get; set; }

        /// <summary>
        /// 订单金额信息
        /// </summary>
        [XmlElement("price_info")]
        public RentOrderPriceInfoVO PriceInfo { get; set; }

        /// <summary>
        /// 优惠信息，包含分期优惠
        /// </summary>
        [XmlElement("promo_info")]
        public RentPromoInfoVO PromoInfo { get; set; }

        /// <summary>
        /// 租赁计划信息
        /// </summary>
        [XmlElement("rent_plan_info")]
        public RentPlanInfoVO RentPlanInfo { get; set; }

        /// <summary>
        /// 租赁订单支付产品、信用产品签约信息
        /// </summary>
        [XmlElement("rent_sign_info")]
        public RentSignInfoVO RentSignInfo { get; set; }

        /// <summary>
        /// 租赁账单信息
        /// </summary>
        [XmlArray("rent_statement_infos")]
        [XmlArrayItem("rent_order_statement_info_v_o")]
        public List<RentOrderStatementInfoVO> RentStatementInfos { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级商户信息
        /// </summary>
        [XmlElement("sub_merchant")]
        public RentSubMerchantVO SubMerchant { get; set; }

        /// <summary>
        /// 原订单关联的买断或续租子订单号列表
        /// </summary>
        [XmlArray("sub_order_ids")]
        [XmlArrayItem("string")]
        public List<string> SubOrderIds { get; set; }

        /// <summary>
        /// 租赁订单标题，用于支付宝小程序订单中心、芝麻租赁频道中对用户展示
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 当商家收单appid与下单appid不一致时才有值
        /// </summary>
        [XmlElement("trade_app_id")]
        public string TradeAppId { get; set; }

        /// <summary>
        /// 用户归还物流信息
        /// </summary>
        [XmlArray("user_delivery_logistics_infos")]
        [XmlArrayItem("rent_fulfillment_delivery_info_v_o")]
        public List<RentFulfillmentDeliveryInfoVO> UserDeliveryLogisticsInfos { get; set; }
    }
}
