using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PcDelegationParams Data Structure.
    /// </summary>
    [Serializable]
    public class PcDelegationParams : AopObject
    {
        /// <summary>
        /// 对AI付代买委托意图做描述
        /// </summary>
        [XmlElement("delegation_desc")]
        public string DelegationDesc { get; set; }

        /// <summary>
        /// 委托任务场景
        /// </summary>
        [XmlElement("delegation_scene")]
        public string DelegationScene { get; set; }

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
        /// null
        /// </summary>
        [XmlArray("external_tradeno_list")]
        [XmlArrayItem("string")]
        public List<string> ExternalTradenoList { get; set; }

        /// <summary>
        /// AI付代买委托总限额，币种为人民币，单位为元
        /// </summary>
        [XmlElement("max_total_amount")]
        public string MaxTotalAmount { get; set; }

        /// <summary>
        /// 委托扣款次数限制
        /// </summary>
        [XmlElement("times_limit")]
        public string TimesLimit { get; set; }

        /// <summary>
        /// AI付代买委托结束时间，默认会处理成 2026-01-30 00:00:00
        /// </summary>
        [XmlElement("validity_end_time")]
        public string ValidityEndTime { get; set; }

        /// <summary>
        /// AI付代买委托任务起始时间，默认会处理成  2026-01-30 00:00:00
        /// </summary>
        [XmlElement("validity_start_time")]
        public string ValidityStartTime { get; set; }
    }
}
