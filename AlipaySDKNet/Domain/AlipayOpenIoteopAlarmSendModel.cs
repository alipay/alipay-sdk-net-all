using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIoteopAlarmSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIoteopAlarmSendModel : AopObject
    {
        /// <summary>
        /// 报警规则id
        /// </summary>
        [XmlElement("alarm_rule_id")]
        public string AlarmRuleId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 时序图id
        /// </summary>
        [XmlElement("sequence_diagram_id")]
        public string SequenceDiagramId { get; set; }
    }
}
