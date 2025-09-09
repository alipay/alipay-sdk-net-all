using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingHouseRentalAddResponse.
    /// </summary>
    public class AlipayCommerceHousingHouseRentalAddResponse : AopResponse
    {
        /// <summary>
        /// 房源id
        /// </summary>
        [XmlElement("housing_id")]
        public string HousingId { get; set; }
    }
}
