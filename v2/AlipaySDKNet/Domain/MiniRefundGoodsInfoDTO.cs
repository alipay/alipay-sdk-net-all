using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniRefundGoodsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniRefundGoodsInfoDTO : AopObject
    {
        /// <summary>
        /// 与alipay.open.mini.order.create接口所传的商品goods_id保持一致
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 提报商品库的商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 提报商品库的商品，sku维度的商品该字段必传
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
