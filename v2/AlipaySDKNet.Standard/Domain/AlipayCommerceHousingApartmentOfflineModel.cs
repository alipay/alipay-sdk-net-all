using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentOfflineModel : AopObject
    {
        /// <summary>
        /// 公寓id
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }

        /// <summary>
        /// 下架原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
