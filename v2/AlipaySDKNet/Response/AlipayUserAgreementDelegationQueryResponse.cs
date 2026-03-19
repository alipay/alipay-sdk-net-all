using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementDelegationQueryResponse.
    /// </summary>
    public class AlipayUserAgreementDelegationQueryResponse : AopResponse
    {
        /// <summary>
        /// AI支付协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 委托号
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }

        /// <summary>
        /// 代买委托场景，与传入值相同
        /// </summary>
        [XmlElement("delegation_tag")]
        public string DelegationTag { get; set; }

        /// <summary>
        /// 外部委托号
        /// </summary>
        [XmlElement("external_delegation_id")]
        public string ExternalDelegationId { get; set; }

        /// <summary>
        /// 总金额上限，单位元，币种人民币
        /// </summary>
        [XmlElement("max_total_amount")]
        public string MaxTotalAmount { get; set; }

        /// <summary>
        /// 剩余可用金额，单位元，币种人民币
        /// </summary>
        [XmlElement("remaining_amount")]
        public string RemainingAmount { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        [XmlElement("remaining_times")]
        public string RemainingTimes { get; set; }

        /// <summary>
        /// 代买委托任务当前状态，不可枚举
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总次数上限
        /// </summary>
        [XmlElement("times_limit")]
        public string TimesLimit { get; set; }

        /// <summary>
        /// 有效期结束时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("validity_end_time")]
        public string ValidityEndTime { get; set; }

        /// <summary>
        /// 有效期开始时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("validity_start_time")]
        public string ValidityStartTime { get; set; }
    }
}
