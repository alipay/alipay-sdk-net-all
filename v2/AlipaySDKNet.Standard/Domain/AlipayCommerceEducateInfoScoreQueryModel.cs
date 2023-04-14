using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInfoScoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateInfoScoreQueryModel : AopObject
    {
        /// <summary>
        /// 扩展信息，json格式字符串
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 参赛者ID
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 外部赛事ID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
