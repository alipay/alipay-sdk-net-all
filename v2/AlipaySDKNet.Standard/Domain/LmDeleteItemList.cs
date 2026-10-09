using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LmDeleteItemList Data Structure.
    /// </summary>
    [Serializable]
    public class LmDeleteItemList : AopObject
    {
        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public long GmtModified { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// Lm商品id
        /// </summary>
        [XmlElement("lm_item_id")]
        public string LmItemId { get; set; }

        /// <summary>
        /// 商品的sku列表
        /// </summary>
        [XmlArray("sku_id_list")]
        [XmlArrayItem("number")]
        public List<long> SkuIdList { get; set; }
    }
}
