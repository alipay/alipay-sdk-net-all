using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPromoInfo : AopObject
    {
        /// <summary>
        /// 商品咨询列表
        /// </summary>
        [XmlArray("item_consult_list")]
        [XmlArrayItem("item_consult_info")]
        public List<ItemConsultInfo> ItemConsultList { get; set; }

        /// <summary>
        /// 单品封面图
        /// </summary>
        [XmlElement("item_cover_pic")]
        public string ItemCoverPic { get; set; }

        /// <summary>
        /// 单品描述
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 单品详情图列表
        /// </summary>
        [XmlArray("item_detail_pic_list")]
        [XmlArrayItem("string")]
        public List<string> ItemDetailPicList { get; set; }

        /// <summary>
        /// 单品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
