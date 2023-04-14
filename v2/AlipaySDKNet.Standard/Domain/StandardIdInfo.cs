using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardIdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StandardIdInfo : AopObject
    {
        /// <summary>
        /// 外部使用规则id
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 使用规则id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
