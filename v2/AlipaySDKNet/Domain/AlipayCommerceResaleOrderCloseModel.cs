using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderCloseModel : AopObject
    {
        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
