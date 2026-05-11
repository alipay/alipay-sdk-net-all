using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentAdditionalUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentAdditionalUploadModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fulfillment_additional_media_list")]
        [XmlArrayItem("fulfillment_additional_media_info")]
        public List<FulfillmentAdditionalMediaInfo> FulfillmentAdditionalMediaList { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
