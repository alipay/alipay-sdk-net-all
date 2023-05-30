using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantInfoDTO : AopObject
    {
        /// <summary>
        /// 授权主体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 主体Id，根据类型确定
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("participant_id_type")]
        public string ParticipantIdType { get; set; }
    }
}
