using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class OrderOpenapi : AopObject
    {
        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("item_image")]
        public string ItemImage { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 开放平台用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单确认收货时间
        /// </summary>
        [XmlElement("order_confirm_delivery_time")]
        public string OrderConfirmDeliveryTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单详情链接
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单支付金额（元）
        /// </summary>
        [XmlElement("order_pay_amount")]
        public string OrderPayAmount { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单退款时间
        /// </summary>
        [XmlElement("order_refund_time")]
        public string OrderRefundTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
