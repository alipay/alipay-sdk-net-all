using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableGoodsInfo : AopObject
    {
        /// <summary>
        /// 可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。
        /// </summary>
        [XmlArray("available_goods_sku_ids")]
        [XmlArrayItem("string")]
        public List<string> AvailableGoodsSkuIds { get; set; }

        /// <summary>
        /// 不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。
        /// </summary>
        [XmlArray("exclude_goods_sku_ids")]
        [XmlArrayItem("string")]
        public List<string> ExcludeGoodsSkuIds { get; set; }

        /// <summary>
        /// 商品描述信息。 用于券面展示，向用户介绍商品
        /// </summary>
        [XmlElement("goods_description")]
        public string GoodsDescription { get; set; }

        /// <summary>
        /// 商品详情，会展示在特定渠道(如服务市场团购业务插件的套餐明细)。
        /// </summary>
        [XmlElement("goods_detail")]
        public string GoodsDetail { get; set; }

        /// <summary>
        /// 商品详情图片列表，会展示在特定渠道(如服务市场团购业务插件的头图)
        /// </summary>
        [XmlArray("goods_detail_images")]
        [XmlArrayItem("string")]
        public List<string> GoodsDetailImages { get; set; }

        /// <summary>
        /// 商品详情富文本描述
        /// </summary>
        [XmlElement("goods_detail_rich_description")]
        public string GoodsDetailRichDescription { get; set; }

        /// <summary>
        /// 商品名称。
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 原价。说明：该字段可不填，填入商品名称goods_name则必填;
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }
    }
}
