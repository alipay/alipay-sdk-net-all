using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantDTO : AopObject
    {
        /// <summary>
        /// 核身主体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 核身主体ID
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 核身主体Id类型
        /// </summary>
        [XmlElement("participant_id_type")]
        public string ParticipantIdType { get; set; }
    }
}
