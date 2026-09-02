using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerIdlefeeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerIdlefeeNotifyModel : AopObject
    {
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
        /// 占位费支付状态 PAID: 已完成支付 UNPAID: 未完成支付，即支付取消或者超时关闭，需重新发起支付 PAID_BY_OTHER: 用户通过其他渠道完成支付
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 占位费支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
