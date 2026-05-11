using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CoreMaterialItemRelation Data Structure.
    /// </summary>
    [Serializable]
    public class CoreMaterialItemRelation : AopObject
    {
        /// <summary>
        /// 整机比（数量）
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
