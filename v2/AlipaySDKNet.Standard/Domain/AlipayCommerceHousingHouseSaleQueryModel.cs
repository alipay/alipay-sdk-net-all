using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingHouseSaleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingHouseSaleQueryModel : AopObject
    {
        /// <summary>
        /// 服务商房源编码(和房源id二选一进行必传)
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 房源ID(和服务商房源编码二选一进行必传) 
        /// </summary>
        [XmlElement("housing_id")]
        public string HousingId { get; set; }
    }
}
