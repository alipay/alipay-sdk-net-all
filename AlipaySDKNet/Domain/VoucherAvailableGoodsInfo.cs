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
        /// 商品描述
        /// </summary>
        [XmlElement("goods_description")]
        public string GoodsDescription { get; set; }

        /// <summary>
        /// 商品名称。
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }
    }
}
