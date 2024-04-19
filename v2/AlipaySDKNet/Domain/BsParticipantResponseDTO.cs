using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsParticipantResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BsParticipantResponseDTO : AopObject
    {
        /// <summary>
        /// 批量操作接口的单个参与者失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 参与类型，支持PARTNER_ID 、LOGON_ID等
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
