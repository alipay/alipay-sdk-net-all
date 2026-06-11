using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizEntity Data Structure.
    /// </summary>
    [Serializable]
    public class BizEntity : AopObject
    {
        /// <summary>
        /// 实体类型id，从前面会话中获取
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }
    }
}
