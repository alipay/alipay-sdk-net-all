using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamepaidgiftOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamepaidgiftOrderQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 游戏平台的唯一订单号，在发货通知的时候传入的platform_order_id
        /// </summary>
        [XmlElement("platform_order_id")]
        public string PlatformOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
