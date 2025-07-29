using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetItemVersion Data Structure.
    /// </summary>
    [Serializable]
    public class AssetItemVersion : AopObject
    {
        /// <summary>
        /// 物料BOM信息
        /// </summary>
        [XmlArray("bom_items")]
        [XmlArrayItem("asset_bom_item")]
        public List<AssetBomItem> BomItems { get; set; }

        /// <summary>
        /// 物料设计稿信息
        /// </summary>
        [XmlArray("design_img")]
        [XmlArrayItem("asset_file_info")]
        public List<AssetFileInfo> DesignImg { get; set; }

        /// <summary>
        /// 物料效果图信息
        /// </summary>
        [XmlArray("effect_img")]
        [XmlArrayItem("asset_file_info")]
        public List<AssetFileInfo> EffectImg { get; set; }

        /// <summary>
        /// 物料版本号
        /// </summary>
        [XmlElement("item_version")]
        public long ItemVersion { get; set; }

        /// <summary>
        /// 物料当前版本的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
