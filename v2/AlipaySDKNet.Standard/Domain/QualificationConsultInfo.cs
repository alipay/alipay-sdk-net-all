using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QualificationConsultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QualificationConsultInfo : AopObject
    {
        /// <summary>
        /// 实体ID
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }
    }
}
