using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemQueryInfo : AopObject
    {
        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品跳转url
        /// </summary>
        [XmlElement("buy_url")]
        public string BuyUrl { get; set; }

        /// <summary>
        /// 币种（默认为人名币）
        /// </summary>
        [XmlElement("currency_type")]
        public string CurrencyType { get; set; }

        /// <summary>
        /// 商品唯一id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("lanch_time")]
        public string LanchTime { get; set; }

        /// <summary>
        /// 计价方式（/天；/月）
        /// </summary>
        [XmlElement("monetary_unit")]
        public string MonetaryUnit { get; set; }

        /// <summary>
        /// 商品现价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlArray("promo_pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PromoPicUrlList { get; set; }

        /// <summary>
        /// 商品推荐分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 商品标签
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }
    }
}
