using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetBom Data Structure.
    /// </summary>
    [Serializable]
    public class AssetBom : AopObject
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlArray("attributes")]
        [XmlArrayItem("asset_bom_attribute")]
        public List<AssetBomAttribute> Attributes { get; set; }

        /// <summary>
        /// 子物料清单
        /// </summary>
        [XmlArray("bom_items")]
        [XmlArrayItem("asset_bom_item")]
        public List<AssetBomItem> BomItems { get; set; }

        /// <summary>
        /// 物料主图
        /// </summary>
        [XmlElement("effect_img")]
        public string EffectImg { get; set; }

        /// <summary>
        /// 物料id
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
