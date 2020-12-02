using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelGoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelGoodsSyncModel : AopObject
    {
        /// <summary>
        /// 商品首图，外部商品图片地址
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 外链地址，仅支持白名单内的H5& 小程序地址
        /// </summary>
        [XmlElement("external_link_url")]
        public string ExternalLinkUrl { get; set; }

        /// <summary>
        /// 商品分类枚举,请向支付宝业务对口BD询问可用的枚举值。
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品标签，可空或传入一个或多个
        /// </summary>
        [XmlArray("goods_tags")]
        [XmlArrayItem("string")]
        public List<string> GoodsTags { get; set; }

        /// <summary>
        /// 是否同步库存，是传Y，否则传N，默认不填为N
        /// </summary>
        [XmlElement("inventory_sync")]
        public string InventorySync { get; set; }

        /// <summary>
        /// 商品原价，币种遵循 ISO 4217 标准，金额数值为正整数且精确到货币最小单位
        /// </summary>
        [XmlElement("original_price")]
        public Amount OriginalPrice { get; set; }

        /// <summary>
        /// 外部商户或第三方的商品ID，app_id、out_shop_id、out_goods_id唯一标识一个商品请求。
        /// </summary>
        [XmlElement("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 外部店铺ID，对于特定行业可选，比如GOL线上商品的场景非必填。app_id、out_shop_id、out_goods_id唯一标识一个商品请求。
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 商品现价，币种遵循 ISO 4217 标准，金额数值为正整数且精确到货币最小单位
        /// </summary>
        [XmlElement("price")]
        public Amount Price { get; set; }

        /// <summary>
        /// 是否推荐，如推荐则平台会优先展示该菜品，是传Y，否则传N，默认不填为N
        /// </summary>
        [XmlElement("recommend")]
        public string Recommend { get; set; }

        /// <summary>
        /// 业务场景，可传入一个或多个,该字段用来标识商品的适用业务场景。
        /// </summary>
        [XmlArray("scenarios")]
        [XmlArrayItem("string")]
        public List<string> Scenarios { get; set; }

        /// <summary>
        /// 商品状态，仅支持指定枚举值，NORMAL表示如正在售卖，CLOSED表示下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
