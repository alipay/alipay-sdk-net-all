using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingApartmentAddResponse.
    /// </summary>
    public class AlipayCommerceHousingApartmentAddResponse : AopResponse
    {
        /// <summary>
        /// 公寓id
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }
    }
}
