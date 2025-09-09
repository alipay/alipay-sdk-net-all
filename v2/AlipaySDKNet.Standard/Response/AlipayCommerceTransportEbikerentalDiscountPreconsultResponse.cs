using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEbikerentalDiscountPreconsultResponse.
    /// </summary>
    public class AlipayCommerceTransportEbikerentalDiscountPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 订单优惠金额，单位元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }
    }
}
