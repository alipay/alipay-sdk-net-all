using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderUserConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderUserConfirmModel : AopObject
    {
        /// <summary>
        /// 确认方
        /// </summary>
        [XmlElement("confirm_role")]
        public string ConfirmRole { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
