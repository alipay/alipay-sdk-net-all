using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechWeatherAlertQueryResponse.
    /// </summary>
    public class DatadigitalAnttechWeatherAlertQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("alerts")]
        [XmlArrayItem("weather_alert_d_t_o")]
        public List<WeatherAlertDTO> Alerts { get; set; }
    }
}
