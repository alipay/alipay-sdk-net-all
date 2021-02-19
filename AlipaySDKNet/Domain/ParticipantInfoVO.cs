using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantInfoVO : AopObject
    {
        /// <summary>
        /// 参与者名称类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 参与者名称
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
