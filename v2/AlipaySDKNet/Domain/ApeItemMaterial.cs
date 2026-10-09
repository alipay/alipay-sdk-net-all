using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeItemMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class ApeItemMaterial : AopObject
    {
        /// <summary>
        /// 商品属性的字段描述
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 绿色无伤，宝妈必备
        /// </summary>
        [XmlElement("custom")]
        public string Custom { get; set; }

        /// <summary>
        /// 商品的详情图
        /// </summary>
        [XmlArray("goods_detail_pic_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsDetailPicList { get; set; }

        /// <summary>
        /// 物品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// https://sl-tas-oss.shulidata.com/marketing/d48551424d88b9813a9f58bf019d69bc.JPEG
        /// </summary>
        [XmlElement("material_pic")]
        public string MaterialPic { get; set; }

        /// <summary>
        /// 商品价格优惠的字段
        /// </summary>
        [XmlElement("price_privilege")]
        public string PricePrivilege { get; set; }
    }
}
