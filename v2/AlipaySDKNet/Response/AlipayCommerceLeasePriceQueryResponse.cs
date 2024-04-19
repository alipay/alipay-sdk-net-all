using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLeasePriceQueryResponse.
    /// </summary>
    public class AlipayCommerceLeasePriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// sku最低价格
        /// </summary>
        [XmlElement("lowest_price")]
        public string LowestPrice { get; set; }

        /// <summary>
        /// 最低价格的sku_id，如果有一样价格的随机返回一个
        /// </summary>
        [XmlElement("lowest_price_sku_id")]
        public string LowestPriceSkuId { get; set; }

        /// <summary>
        /// sku价格信息
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("lease_item_sku_d_t_o")]
        public List<LeaseItemSkuDTO> Skus { get; set; }
    }
}
