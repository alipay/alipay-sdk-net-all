using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayDelegationTaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayDelegationTaskModifyModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 委托任务id
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }

        /// <summary>
        /// 之前授权的最大金额，单位元
        /// </summary>
        [XmlElement("pre_max_total_amount")]
        public string PreMaxTotalAmount { get; set; }

        /// <summary>
        /// 预期最大授权金额，单位元
        /// </summary>
        [XmlElement("target_max_total_amount")]
        public string TargetMaxTotalAmount { get; set; }

        /// <summary>
        /// 允许代扣处理3次
        /// </summary>
        [XmlElement("times_limit")]
        public string TimesLimit { get; set; }

        /// <summary>
        /// AI付代买委托结束时间，默认会处理成 2026-01-30 00:00:00
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// AI付代买委托结束时间，默认会处理成 2026-01-30 00:00:00
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }
    }
}
