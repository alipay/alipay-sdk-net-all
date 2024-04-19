using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsItemDTO : AopObject
    {
        /// <summary>
        /// 商户侧商品的编号，应与alipay.open.mini.order.create接口所传的商品goods_id保持一致
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public long ItemCnt { get; set; }

        /// <summary>
        /// 商户商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户商品sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
