using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OBPersonalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OBPersonalDTO : AopObject
    {
        /// <summary>
        /// 个人实体id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 个人实体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }
    }
}
