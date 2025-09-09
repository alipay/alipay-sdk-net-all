using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderDelegateConfirmModel : AopObject
    {
        /// <summary>
        /// 淘宝平铺店铺：BRAND
        /// </summary>
        [XmlElement("delegate_type")]
        public string DelegateType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
