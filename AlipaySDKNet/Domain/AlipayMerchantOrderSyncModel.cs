using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家userId
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// buyer_info与buyer_user_id必选其一
        /// </summary>
        [XmlElement("buyer_info")]
        public UserInfomation BuyerInfo { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 扩展信息，请参见产品文档
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_info")]
        public List<ItemOrderInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 物流信息  列表最多支持物流信息个数，请参考产品文档  注：若该值不为空，且物流信息同步至我的快递，则在查询订单时可返回具体物流信息
        /// </summary>
        [XmlArray("logistics_info_list")]
        [XmlArrayItem("order_logistics_information_request")]
        public List<OrderLogisticsInformationRequest> LogisticsInfoList { get; set; }

        /// <summary>
        /// 订单授权码(与订单一一对应，不是请求维度的，服务订单首次同步必传） 利用订单同步前获取的formId作为订单授权码。订单授权码对应的小程序id与买家uid与同步订单的小程序id和买家uid一致 注：当order_type为SERVICE_ORDER时必填
        /// </summary>
        [XmlElement("order_auth_code")]
        public string OrderAuthCode { get; set; }

        /// <summary>
        /// 订单创建时间 当order_type为SERVICE_ORDER时必传
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单支付时间 当pay_channel为非ALIPAY时，且订单状态已流转到“支付”或支付后时，需要将支付时间传入
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单类型，若为空，默认为交易订单，每次请求必传 -SERVICE_ORDER：服务订单 -TRADE_ORDER：交易订单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号 out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易对应的签约商户userId 注意：该字段自2020-02-16日起，可以不传入
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付金额 需要实际支付的金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付超时时间，超过时间支付宝自行关闭订单
        /// </summary>
        [XmlElement("pay_timeout_express")]
        public string PayTimeoutExpress { get; set; }

        /// <summary>
        /// 商户订单同步记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 卖家userId 注意：该字段自2020-02-16日起，可以不传入
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public OrderShopInfo ShopInfo { get; set; }

        /// <summary>
        /// 凭证信息
        /// </summary>
        [XmlElement("ticket_info")]
        public TicketInfo TicketInfo { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易号类型 1. TRADE-交易，为空默认为TRADE 2. TRANSFER-转账 3. ENTRUST-受托
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
