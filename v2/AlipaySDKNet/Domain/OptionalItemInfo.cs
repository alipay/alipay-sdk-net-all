using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OptionalItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OptionalItemInfo : AopObject
    {
        /// <summary>
        /// 选配物料对应数量
        /// </summary>
        [XmlElement("apply_count")]
        public string ApplyCount { get; set; }

        /// <summary>
        /// 选配物料id
        /// </summary>
        [XmlElement("optional_item_id")]
        public string OptionalItemId { get; set; }
    }
}
