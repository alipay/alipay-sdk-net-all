using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInfoParticipantCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateInfoParticipantCertifyModel : AopObject
    {
        /// <summary>
        /// 参赛者信息
        /// </summary>
        [XmlArray("participant_info")]
        [XmlArrayItem("participant_info")]
        public List<ParticipantInfo> ParticipantInfo { get; set; }

        /// <summary>
        /// 外部赛事ID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
