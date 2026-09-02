using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResaleOrderDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResaleOrderDetailVO : AopObject
    {
        /// <summary>
        /// 履约信息
        /// </summary>
        [XmlElement("delivery_info")]
        public ResaleDeliveryInfoVO DeliveryInfo { get; set; }

        /// <summary>
        /// 商品信息集合
        /// </summary>
        [XmlElement("item_info_list")]
        public ResaleOrderItemVO ItemInfoList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额，元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 使用超链接格式展示链接。
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 二手售卖订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("order_memo")]
        public string OrderMemo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("ppi_order_id")]
        public string PpiOrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("trade_info_list")]
        [XmlArrayItem("resale_fund_info_v_o")]
        public List<ResaleFundInfoVO> TradeInfoList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
