using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherAvailableGoodsModify Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherAvailableGoodsModify : AopObject
    {
        /// <summary>
        /// 可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。 限制: 1、核销商品范围只能增大不能减小
        /// </summary>
        [XmlArray("goods_ids")]
        [XmlArrayItem("string")]
        public List<string> GoodsIds { get; set; }
    }
}
