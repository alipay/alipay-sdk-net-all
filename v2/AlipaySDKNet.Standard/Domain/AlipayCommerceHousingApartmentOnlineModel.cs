using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentOnlineModel : AopObject
    {
        /// <summary>
        /// 公寓id
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }
    }
}
