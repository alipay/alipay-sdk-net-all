using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniWidgetGoodsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniWidgetGoodsModifyModel : AopObject
    {
        /// <summary>
        /// 需要修改的商品小程序购买链接
        /// </summary>
        [XmlElement("buying_url")]
        public string BuyingUrl { get; set; }

        /// <summary>
        /// 需要修改的商品品牌
        /// </summary>
        [XmlElement("goods_brand")]
        public string GoodsBrand { get; set; }

        /// <summary>
        /// 需要修改的商品辅助说明文案
        /// </summary>
        [XmlElement("goods_comment")]
        public string GoodsComment { get; set; }

        /// <summary>
        /// 需要修改的商品说明标签（如-随心退）
        /// </summary>
        [XmlElement("goods_description_label")]
        public string GoodsDescriptionLabel { get; set; }

        /// <summary>
        /// 商品的唯一标识，根据该字段修改商品
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 需要修改的商品营销标签（如-限量特价），每个商品仅支持一个营销标签
        /// </summary>
        [XmlElement("goods_label")]
        public string GoodsLabel { get; set; }

        /// <summary>
        /// 需要修改的商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 需要修改的商品所属品类
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 需要修改的商品主图片地址
        /// </summary>
        [XmlElement("main_pic_url")]
        public string MainPicUrl { get; set; }

        /// <summary>
        /// 是否需要进行公域推广
        /// </summary>
        [XmlElement("need_public_promo")]
        public bool NeedPublicPromo { get; set; }

        /// <summary>
        /// 需要修改的商品排序，自然整数, 数字越小越靠前
        /// </summary>
        [XmlElement("order_number")]
        public long OrderNumber { get; set; }

        /// <summary>
        /// 需要修改的商品原价，单位"元"，传入数字，不需要传入"元"
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 需要修改的商品投放城市的列表，详见https://www.mca.gov.cn/article/sj/xzqh/2020/2020/202007170301.html，有多个用英文,分隔。如果没有限制则不传入
        /// </summary>
        [XmlElement("publish_cities")]
        public string PublishCities { get; set; }

        /// <summary>
        /// 需要修改的商品售价，位"元"，传入数字，不需要传入"元"
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 需要修改的商品卖点标签
        /// </summary>
        [XmlArray("sell_tag_list")]
        [XmlArrayItem("string")]
        public List<string> SellTagList { get; set; }
    }
}
