using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingApartmentRentalAddResponse.
    /// </summary>
    public class AlipayCommerceHousingApartmentRentalAddResponse : AopResponse
    {
        /// <summary>
        /// 公寓房源id
        /// </summary>
        [XmlElement("apartment_house_id")]
        public string ApartmentHouseId { get; set; }
    }
}
