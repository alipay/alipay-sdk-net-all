using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOuterorderCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalOuterorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 履约的URL
        /// </summary>
        [XmlElement("fulfillment_url")]
        public string FulfillmentUrl { get; set; }

        /// <summary>
        /// 合作方订单号
        /// </summary>
        [XmlElement("partner_order_id")]
        public string PartnerOrderId { get; set; }
    }
}
