using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizEntityId Data Structure.
    /// </summary>
    [Serializable]
    public class BizEntityId : AopObject
    {
        /// <summary>
        /// 实体id，通过查询房源信息得到房源ID，订单信息得到订单ID
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
