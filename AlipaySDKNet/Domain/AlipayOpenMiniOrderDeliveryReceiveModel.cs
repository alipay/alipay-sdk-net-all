using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderDeliveryReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderDeliveryReceiveModel : AopObject
    {
        /// <summary>
        /// 商户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。order_id、out_order_id，二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 商户UID（与openId二选一）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
