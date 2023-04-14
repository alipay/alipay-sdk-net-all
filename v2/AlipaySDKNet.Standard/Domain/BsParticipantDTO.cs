using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsParticipantDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BsParticipantDTO : AopObject
    {
        /// <summary>
        /// 参与者类型，支持PARTNER_ID 、LOGON_ID等
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 类型对应值,传参也不一样
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
