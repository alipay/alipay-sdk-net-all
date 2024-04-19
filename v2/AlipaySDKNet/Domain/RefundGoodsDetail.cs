using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundGoodsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RefundGoodsDetail : AopObject
    {
        /// <summary>
        /// 商品编号。 对应支付时传入的goods_id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商家侧小程序商品ID，具体使用方式请参考：https://opendocs.alipay.com/pre-open/06uila?pathHash=87297d0a
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧小程序商品sku ID，具体使用方式请参考：https://opendocs.alipay.com/pre-open/06uila?pathHash=87297d0a
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 该商品的退款总金额，单位为元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
