using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMetroStationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportMetroStationQueryModel : AopObject
    {
        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }
    }
}
