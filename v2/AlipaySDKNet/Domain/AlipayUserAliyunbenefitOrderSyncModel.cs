using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAliyunbenefitOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAliyunbenefitOrderSyncModel : AopObject
    {
        /// <summary>
        /// LinkedMall订单号
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 订单状态变更时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 积分已支付
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 阿里云侧流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 待支付
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
