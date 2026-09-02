using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMetroRealtimeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportMetroRealtimeQueryModel : AopObject
    {
        /// <summary>
        /// 北京市城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 线路code
        /// </summary>
        [XmlElement("line_code")]
        public string LineCode { get; set; }

        /// <summary>
        /// 地铁站名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }
    }
}
