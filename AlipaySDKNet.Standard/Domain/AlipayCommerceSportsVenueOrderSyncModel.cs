using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单交易状态,pay_succ-已支付（若支持多次核销则在全部核销之前都是已支付状态）,refund_succ-已退款,verify_succ-已使用。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型，venue_reverse-场馆预订单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 收款方pid，对应交易的seller_id
        /// </summary>
        [XmlElement("payee_id")]
        public string PayeeId { get; set; }

        /// <summary>
        /// 订单商品信息列表
        /// </summary>
        [XmlArray("product_group_list")]
        [XmlArrayItem("product_simple_info")]
        public List<ProductSimpleInfo> ProductGroupList { get; set; }

        /// <summary>
        /// 退款截止时间。默认为空表示不能由用户发起退款；如果不为空，则在该时间之前用户可以发起退款。
        /// </summary>
        [XmlElement("refund_end_time")]
        public string RefundEndTime { get; set; }

        /// <summary>
        /// 支付宝退款请求号，订单若为退款成功则该字段必填
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 支付宝子场馆ID，场馆入驻时支付宝返回的子场馆ID
        /// </summary>
        [XmlElement("sub_venue_id")]
        public string SubVenueId { get; set; }

        /// <summary>
        /// 订单总金额(单位：元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家支付宝用户ID,2088开头的16位纯数字
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝主场馆ID，场馆入驻时支付宝返回的主场馆ID
        /// </summary>
        [XmlElement("venue_id")]
        public string VenueId { get; set; }
    }
}
