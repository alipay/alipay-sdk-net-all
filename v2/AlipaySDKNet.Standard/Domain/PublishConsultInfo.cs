using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublishConsultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PublishConsultInfo : AopObject
    {
        /// <summary>
        /// 权益数额，如果是金额类型则单位是分，如果是数量类型则单位是个
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 实体id，如类目id、券id、模板id等
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }
    }
}
