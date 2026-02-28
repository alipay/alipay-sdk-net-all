using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceItembookingBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceItembookingBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("lifeservice_item_booking_relation")]
        public List<LifeserviceItemBookingRelation> Content { get; set; }
    }
}
