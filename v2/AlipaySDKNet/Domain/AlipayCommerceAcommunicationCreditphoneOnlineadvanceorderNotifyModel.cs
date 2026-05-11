using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOnlineadvanceorderNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneOnlineadvanceorderNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝在线提前结清测算单号
        /// </summary>
        [XmlElement("alipay_online_advance_pay_order_no")]
        public string AlipayOnlineAdvancePayOrderNo { get; set; }

        /// <summary>
        /// 减免金额，单位元
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 无测算结果原因
        /// </summary>
        [XmlElement("evaluate_fail_reason")]
        public string EvaluateFailReason { get; set; }

        /// <summary>
        /// 是否有测算结果
        /// </summary>
        [XmlElement("evaluate_success")]
        public bool EvaluateSuccess { get; set; }

        /// <summary>
        /// 罚息，单位 元
        /// </summary>
        [XmlElement("fine_interest")]
        public string FineInterest { get; set; }

        /// <summary>
        /// 手续费，单位 元
        /// </summary>
        [XmlElement("handling_fee")]
        public string HandlingFee { get; set; }

        /// <summary>
        /// 机构侧测算单号
        /// </summary>
        [XmlElement("inst_pay_order_no")]
        public string InstPayOrderNo { get; set; }

        /// <summary>
        /// 应还利息，单位 元
        /// </summary>
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 开放下次测算时间
        /// </summary>
        [XmlElement("next_retry_time")]
        public string NextRetryTime { get; set; }

        /// <summary>
        /// 支付链接，一般是支付宝小程序链接
        /// </summary>
        [XmlElement("pay_link_url")]
        public string PayLinkUrl { get; set; }

        /// <summary>
        /// 应还本金，单位 元
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 应还总额，单位 元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
