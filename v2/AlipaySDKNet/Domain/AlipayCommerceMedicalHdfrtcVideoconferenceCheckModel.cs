using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferenceCheckModel : AopObject
    {
        /// <summary>
        /// Space:医生 Patient:患者
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 外部来源ID，如执行单ID
        /// </summary>
        [XmlElement("source_id")]
        public long SourceId { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 医生空间ID
        /// </summary>
        [XmlElement("space_id")]
        public long SpaceId { get; set; }

        /// <summary>
        /// 好大夫侧用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
