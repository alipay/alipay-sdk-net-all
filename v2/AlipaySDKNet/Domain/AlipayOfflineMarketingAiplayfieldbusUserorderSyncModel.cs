using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingAiplayfieldbusUserorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingAiplayfieldbusUserorderSyncModel : AopObject
    {
        /// <summary>
        /// 订单额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 子单标志
        /// </summary>
        [XmlElement("detail_flag")]
        public long DetailFlag { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// lm订单id
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 主单标志
        /// </summary>
        [XmlElement("main_flag")]
        public long MainFlag { get; set; }

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
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 之前订单状态
        /// </summary>
        [XmlElement("pre_order_status")]
        public long PreOrderStatus { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
