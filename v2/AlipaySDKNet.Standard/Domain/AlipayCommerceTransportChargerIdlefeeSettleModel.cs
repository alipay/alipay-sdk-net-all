using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerIdlefeeSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerIdlefeeSettleModel : AopObject
    {
        /// <summary>
        /// 占位费结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 订单包含的免费占位时长，单位：分钟，整数
        /// </summary>
        [XmlElement("free_duration")]
        public long FreeDuration { get; set; }

        /// <summary>
        /// 是否使用支付宝支付渠道 true: 待用户使用支付宝付款 false: 用户已使用其他渠道完成支付
        /// </summary>
        [XmlElement("need_pay")]
        public bool NeedPay { get; set; }

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
        /// 占位费订单待支付金额，单位：元，两位小数
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 占位费开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 占位费订单总金额，单位：元，两位小数
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
