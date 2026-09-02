using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerIdlefeeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerIdlefeeCreateModel : AopObject
    {
        /// <summary>
        /// 占位费计费规则或者单价
        /// </summary>
        [XmlElement("billing_rule")]
        public string BillingRule { get; set; }

        /// <summary>
        /// 商户充电业务订单号
        /// </summary>
        [XmlElement("charge_order_no")]
        public string ChargeOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户占位费订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 占位费开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
