using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerproductionCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceFarmerproductionCreateResponse : AopResponse
    {
        /// <summary>
        /// 产量记录唯一标识 
        /// </summary>
        [XmlElement("farmer_item_id")]
        public string FarmerItemId { get; set; }
    }
}
