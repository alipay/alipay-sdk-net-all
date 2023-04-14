using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiHeatmapQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiHeatmapQueryModel : AopObject
    {
        /// <summary>
        /// 城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
