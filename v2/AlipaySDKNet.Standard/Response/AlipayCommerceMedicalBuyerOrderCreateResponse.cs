using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBuyerOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalBuyerOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
