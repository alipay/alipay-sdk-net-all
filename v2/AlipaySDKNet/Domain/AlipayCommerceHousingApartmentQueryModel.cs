using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentQueryModel : AopObject
    {
        /// <summary>
        /// 业务系统公寓唯一编码
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }

        /// <summary>
        /// 外部房源唯一编码
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
