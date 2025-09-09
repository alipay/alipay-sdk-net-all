using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppBainaOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppBainaOrderSyncModel : AopObject
    {
        /// <summary>
        /// 该单金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品订单详细说明
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 子单标识。为1表示子单   （一单一品，主子单标志均为1）
        /// </summary>
        [XmlElement("detail_flag")]
        public long DetailFlag { get; set; }

        /// <summary>
        /// 订单商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("order_item_detail")]
        public List<OrderItemDetail> Items { get; set; }

        /// <summary>
        /// linkmall侧订单号
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 主单标识,为1表示主单
        /// </summary>
        [XmlElement("main_flag")]
        public long MainFlag { get; set; }

        /// <summary>
        /// linkedmall主订单号
        /// </summary>
        [XmlElement("main_lm_order_id")]
        public string MainLmOrderId { get; set; }

        /// <summary>
        /// 订单变化时间戳，单位为毫秒
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 变化后的订单状态
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 外部请求编号，编号相同则认为是同一请求
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单变化前状态,创建订单是无前置状态
        /// </summary>
        [XmlElement("pre_order_status")]
        public long PreOrderStatus { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
