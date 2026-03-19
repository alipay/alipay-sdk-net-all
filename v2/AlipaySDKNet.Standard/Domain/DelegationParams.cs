using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelegationParams Data Structure.
    /// </summary>
    [Serializable]
    public class DelegationParams : AopObject
    {
        /// <summary>
        /// 对AI付代买委托意图做描述
        /// </summary>
        [XmlElement("delegation_desc")]
        public string DelegationDesc { get; set; }

        /// <summary>
        /// 描述代买委托
        /// </summary>
        [XmlElement("delegation_tag")]
        public string DelegationTag { get; set; }

        /// <summary>
        /// 外部商户AI付代买委托id，用于委托申请成功后区分不同的委托任务
        /// </summary>
        [XmlElement("external_delegation_id")]
        public string ExternalDelegationId { get; set; }

        /// <summary>
        /// AI付代买委托总限额，币种为人民币，单位为元
        /// </summary>
        [XmlElement("max_total_amount")]
        public string MaxTotalAmount { get; set; }

        /// <summary>
        /// AI付代买委托总次数
        /// </summary>
        [XmlElement("times_limit")]
        public string TimesLimit { get; set; }

        /// <summary>
        /// AI付代买委托总次数 当前字段已废弃(拼写错误，迁移至times_limit字段)
        /// </summary>
        [XmlElement("times_timit")]
        public string TimesTimit { get; set; }

        /// <summary>
        /// AI付代买委托结束时间
        /// </summary>
        [XmlElement("validity_end_time")]
        public string ValidityEndTime { get; set; }

        /// <summary>
        /// AI付代买委托任务起始时间
        /// </summary>
        [XmlElement("validity_start_time")]
        public string ValidityStartTime { get; set; }
    }
}
