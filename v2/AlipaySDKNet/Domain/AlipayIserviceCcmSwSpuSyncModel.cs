using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwSpuSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwSpuSyncModel : AopObject
    {
        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("attribute")]
        [XmlArrayItem("spu_attribute")]
        public List<SpuAttribute> Attribute { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品类目，用于商品库中分类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品图片链接 特殊可选规则：is_delete=false的情况下必填
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 默认为false，为true，表示删除知识点
        /// </summary>
        [XmlElement("is_delete")]
        public string IsDelete { get; set; }

        /// <summary>
        /// 知识库id
        /// </summary>
        [XmlElement("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [XmlElement("library_name")]
        public string LibraryName { get; set; }

        /// <summary>
        /// 商品链接 特殊可选规则：is_delete=false的情况下必填
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品售价 特殊可选规则：is_delete=false的情况下必填
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品状态：AVAILABLE 表示可售卖,SOLD_OUT为售罄/不可卖，默认可售卖
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品名称 特殊可选规则：is_delete=false的情况下必填
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
