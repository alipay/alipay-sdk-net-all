using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSearchboxItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSearchboxItemSyncModel : AopObject
    {
        /// <summary>
        /// 商品所属类目，注意类目需先完成提报及审核；建议长度控制在 128 字符之内
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品描述，仅用于部分业务场景，参考对接文档
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 商户内部商品id，类目下唯一
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片素材url，通过图片上传接口获取
        /// </summary>
        [XmlElement("item_image")]
        public string ItemImage { get; set; }

        /// <summary>
        /// 运营管理后台使用，不对客展示
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 类目下正序排列；默认排序仅在其他排序规则不生效时使用，规则参考业务接入文档
        /// </summary>
        [XmlElement("item_order")]
        public long ItemOrder { get; set; }

        /// <summary>
        /// 对客展示用，传参规则见业务对接文档
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品下单或充值页链接
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品原价（元），即划线价，仅用于部分业务场景，参考对接文档，单位：元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品售价（元）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 仅用于部分业务场景，参考对接文档；参考单位：元/季、元/件、元/日
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }
    }
}
