using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsQueryResponse : AopObject
    {
        /// <summary>
        /// 支付宝内部商品唯一标识
        /// </summary>
        [XmlElement("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 该商品的小程序购买链接
        /// </summary>
        [XmlElement("buying_url")]
        public string BuyingUrl { get; set; }

        /// <summary>
        /// 商品辅助说明文案
        /// </summary>
        [XmlElement("goods_comment")]
        public string GoodsComment { get; set; }

        /// <summary>
        /// 商品说明标签（如-随心退）
        /// </summary>
        [XmlElement("goods_description_label")]
        public string GoodsDescriptionLabel { get; set; }

        /// <summary>
        /// 商品的唯一标识，同一个小部件下，该标识唯一，请开发者自行保证
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 营销标签（如-限量特价），每个商品仅支持一个营销标签
        /// </summary>
        [XmlElement("goods_label")]
        public string GoodsLabel { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品所属品类
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 商品主图片地址
        /// </summary>
        [XmlElement("main_pic_url")]
        public string MainPicUrl { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商品排序，自然整数, 数字越小越靠前
        /// </summary>
        [XmlElement("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// 单位"元"的商品原价，传入数字，不需要传入"元"
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 品的售卖商家，即承接该品的小程序背后的商家。和mini_app_id要求对应
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 投放城市的列表，详见https://www.mca.gov.cn/article/sj/xzqh/2020/2020/202007170301.html，有多个用英文,分隔。如果没有限制则不传入
        /// </summary>
        [XmlElement("publish_cities")]
        public string PublishCities { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [XmlElement("remaining_quantity")]
        public long RemainingQuantity { get; set; }

        /// <summary>
        /// 单位"元"的售价，传入数字，不需要传入"元"
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 已售数量
        /// </summary>
        [XmlElement("sold_quantity")]
        public long SoldQuantity { get; set; }

        /// <summary>
        /// 总库存量
        /// </summary>
        [XmlElement("total_quantity")]
        public string TotalQuantity { get; set; }
    }
}
