using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenNppdUserorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenNppdUserorderSyncModel : AopObject
    {
        /// <summary>
        /// 订单金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 客户业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 子单标志
        /// </summary>
        [XmlElement("detail_flag")]
        public long DetailFlag { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 主单标志
        /// </summary>
        [XmlElement("main_flag")]
        public long MainFlag { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        [XmlElement("main_lm_order_id")]
        public string MainLmOrderId { get; set; }

        /// <summary>
        /// 变化时间
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
        /// 变化后的订单状态
        /// </summary>
        [XmlElement("pre_order_status")]
        public long PreOrderStatus { get; set; }

        /// <summary>
        /// 请求标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
