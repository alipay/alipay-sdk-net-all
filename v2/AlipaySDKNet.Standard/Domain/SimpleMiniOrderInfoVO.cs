using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleMiniOrderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleMiniOrderInfoVO : AopObject
    {
        /// <summary>
        /// 创建时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单总价，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家自定义订单ID(字符仅支持下划线字母数字，长度小于128个字符）
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
