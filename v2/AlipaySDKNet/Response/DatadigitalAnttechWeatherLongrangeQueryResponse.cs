using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechWeatherLongrangeQueryResponse.
    /// </summary>
    public class DatadigitalAnttechWeatherLongrangeQueryResponse : AopResponse
    {
        /// <summary>
        /// 最新批次生成时间
        /// </summary>
        [XmlElement("forecast_batch_time")]
        public string ForecastBatchTime { get; set; }

        /// <summary>
        /// 预测的气象参数列表
        /// </summary>
        [XmlArray("weather_variables_list")]
        [XmlArrayItem("long_range_weather_variables")]
        public List<LongRangeWeatherVariables> WeatherVariablesList { get; set; }
    }
}
