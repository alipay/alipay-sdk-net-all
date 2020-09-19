using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolcreditConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTuitionSchoolcreditConfirmModel : AopObject
    {
        /// <summary>
        /// 支付内部交易流水号
        /// </summary>
        [XmlElement("alipay_payment_id")]
        public string AlipayPaymentId { get; set; }

        /// <summary>
        /// 汇款入账金额
        /// </summary>
        [XmlElement("confirm_amount")]
        public Money ConfirmAmount { get; set; }

        /// <summary>
        /// 汇款入账结果
        /// </summary>
        [XmlElement("confirm_result")]
        public TuitionISVResult ConfirmResult { get; set; }

        /// <summary>
        /// 汇款入账时间
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// ISV内部账单号
        /// </summary>
        [XmlElement("isv_payment_id")]
        public string IsvPaymentId { get; set; }

        /// <summary>
        /// ISV在开放平台入驻签约的PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 业务透传保留字段，json map格式
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 学校在开放平台入驻签约的PID
        /// </summary>
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }
    }
}
