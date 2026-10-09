using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherAvailableGoods Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherAvailableGoods : AopObject
    {
        /// <summary>
        /// 商品描述信息。 用于券面展示，向用户介绍商品
        /// </summary>
        [XmlElement("goods_description")]
        public string GoodsDescription { get; set; }

        /// <summary>
        /// 可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。
        /// </summary>
        [XmlArray("goods_ids")]
        [XmlArrayItem("string")]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }
    }
}
