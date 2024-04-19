using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePeriodorderCancelResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphonePeriodorderCancelResponse : AopResponse
    {
        /// <summary>
        /// 当期支付宝订单号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝用户id
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
        /// 当期金额，单位元
        /// </summary>
        [XmlElement("period_amount")]
        public string PeriodAmount { get; set; }

        /// <summary>
        /// 当期处理状态
        /// </summary>
        [XmlElement("period_status")]
        public string PeriodStatus { get; set; }

        /// <summary>
        /// 当期期数
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
