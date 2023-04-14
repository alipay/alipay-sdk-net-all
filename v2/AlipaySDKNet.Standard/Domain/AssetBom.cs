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
        /// 物料子类型
        /// </summary>
        [XmlElement("asset_sub_type")]
        public string AssetSubType { get; set; }

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
        /// 物料是否包含码
        /// </summary>
        [XmlElement("include_qrcode")]
        public string IncludeQrcode { get; set; }

        /// <summary>
        /// 是否是套组物料
        /// </summary>
        [XmlElement("is_suite")]
        public string IsSuite { get; set; }

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

        /// <summary>
        /// 物料类别
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 物料信息查询的版本
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
