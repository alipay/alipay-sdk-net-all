using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechWeatherShorttermQueryResponse.
    /// </summary>
    public class DatadigitalAnttechWeatherShorttermQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("short_term_rains")]
        [XmlArrayItem("weather_short_term_rain_d_t_o")]
        public List<WeatherShortTermRainDTO> ShortTermRains { get; set; }
    }
}
