using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentRentalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentRentalQueryModel : AopObject
    {
        /// <summary>
        /// 公寓房源id
        /// </summary>
        [XmlElement("apartment_house_id")]
        public string ApartmentHouseId { get; set; }

        /// <summary>
        /// 外部房源id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
