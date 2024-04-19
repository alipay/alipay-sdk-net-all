using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRule Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRule : AopObject
    {
        /// <summary>
        /// 时间戳，规则生效截止时间 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 限时取消细节 CAN_REFUND时候有该结构
        /// </summary>
        [XmlArray("refund_rule_details")]
        [XmlArrayItem("refund_rule_detail")]
        public List<RefundRuleDetail> RefundRuleDetails { get; set; }

        /// <summary>
        /// 退款规则id
        /// </summary>
        [XmlElement("refund_rule_id")]
        public string RefundRuleId { get; set; }

        /// <summary>
        /// 取消类型
        /// </summary>
        [XmlElement("refund_rule_type")]
        public string RefundRuleType { get; set; }

        /// <summary>
        /// 时间戳，规则生效起始时间 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
