using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCompetitionapplyStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCompetitionapplyStatusSyncModel : AopObject
    {
        /// <summary>
        /// 参赛状态:
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 参赛者id，由支付宝系统生成，如果需要更改报名状态，需要传此字段
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 参赛人信息
        /// </summary>
        [XmlElement("participant_info")]
        public ParticipantInfo ParticipantInfo { get; set; }

        /// <summary>
        /// 外部赛事ID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
