using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideorecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideorecordQueryModel : AopObject
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 好大夫侧获取外部来源ID，如执行单ID
        /// </summary>
        [XmlElement("source_id")]
        public long SourceId { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
