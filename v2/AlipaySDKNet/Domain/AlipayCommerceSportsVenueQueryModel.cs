using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueQueryModel : AopObject
    {
        /// <summary>
        /// 服务商场馆ID
        /// </summary>
        [XmlElement("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 支付宝场馆ID
        /// </summary>
        [XmlElement("venue_id")]
        public string VenueId { get; set; }
    }
}
