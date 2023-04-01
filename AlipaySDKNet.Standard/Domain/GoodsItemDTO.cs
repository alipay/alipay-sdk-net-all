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
        /// 商家goods_id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public long ItemCnt { get; set; }

        /// <summary>
        /// 提报服务库外部商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家自定义skuID
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
