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
        /// 买家支付宝OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单交易状态,pay_succ-已支付（若支持多次核销则在全部核销之前都是已支付状态）,refund_succ-已退款,verify_proc-使用中（已入场但是还未结束）,verify_succ-已使用,overdue-已过期（超过使用时间未使用且未退款）
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型，venue_reserve-场馆预订单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// isv子场馆id，与场馆入驻时一致，须保证系统内唯一。如果在场馆入驻时有子场馆则传入入住时的out_sub_venue_id；如果场馆入驻时不存在子场馆，则无须传入。
        /// </summary>
        [XmlElement("out_sub_venue_id")]
        public string OutSubVenueId { get; set; }

        /// <summary>
        /// isv场馆id，与场馆入驻时一致，须保证系统内唯一。和venue_id之间至少存在一个
        /// </summary>
        [XmlElement("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 订单商品信息列表，目前仅支持1笔订单1条商品信息数据，即一笔订单只能包含1种商品。
        /// </summary>
        [XmlArray("product_group_list")]
        [XmlArrayItem("product_simple_info")]
        public List<ProductSimpleInfo> ProductGroupList { get; set; }

        /// <summary>
        /// 支付宝子场馆ID，场馆入驻时支付宝返回的子场馆ID。如果在场馆入驻时有子场馆则传入入驻时返回的sub_venue_id；如果场馆入驻时不存在子场馆，则无须传入。
        /// </summary>
        [XmlElement("sub_venue_id")]
        public string SubVenueId { get; set; }

        /// <summary>
        /// 订单总金额(单位：元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单的交易信息列表，传入支付、退款等操作的信息。第一次同步必传；第一次同步之后如果没有交易变化则调用时可以不传本参数。每一条交易数据同步后不支持修改。
        /// </summary>
        [XmlArray("trade_info_list")]
        [XmlArrayItem("venue_order_trade_info")]
        public List<VenueOrderTradeInfo> TradeInfoList { get; set; }

        /// <summary>
        /// 买家支付宝用户ID,2088开头的16位纯数字
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝主场馆ID，场馆入驻时支付宝返回的主场馆ID。和out_venue_id之间至少存在一个
        /// </summary>
        [XmlElement("venue_id")]
        public string VenueId { get; set; }
    }
}
