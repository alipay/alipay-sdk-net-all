using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceWeatherinfosQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceWeatherinfosQueryResponse : AopResponse
    {
        /// <summary>
        /// 气象信息
        /// </summary>
        [XmlArray("weather_infos")]
        [XmlArrayItem("weather_info")]
        public List<WeatherInfo> WeatherInfos { get; set; }
    }
}
