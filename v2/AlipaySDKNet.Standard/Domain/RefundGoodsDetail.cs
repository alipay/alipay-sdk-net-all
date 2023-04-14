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
        /// 该商品的退款总金额，单位为元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
