using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LmModifyItemList Data Structure.
    /// </summary>
    [Serializable]
    public class LmModifyItemList : AopObject
    {
        /// <summary>
        /// 是否可售卖
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 修改时间，毫秒级时间戳
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
        /// 商品sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("lm_modify_sku_list")]
        public List<LmModifySkuList> SkuList { get; set; }
    }
}
