using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePeriodorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphonePeriodorderCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝主单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 当期外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户当期金额，单位元
        /// </summary>
        [XmlElement("period_amount")]
        public string PeriodAmount { get; set; }

        /// <summary>
        /// 合约机分期数
        /// </summary>
        [XmlElement("step_number")]
        public long StepNumber { get; set; }

        /// <summary>
        /// 用户本期状态
        /// </summary>
        [XmlElement("user_period_status")]
        public string UserPeriodStatus { get; set; }
    }
}
