using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechWeatherFutureQueryResponse.
    /// </summary>
    public class DatadigitalAnttechWeatherFutureQueryResponse : AopResponse
    {
        /// <summary>
        /// 消耗的token数量。 quota 的计量逻辑为13440个（例如14 天*10 个变量*一天 96 个数值）数值为一个单位，用户一次请求如果小于等于一个单位，则记为一个单位，如果大于一个单位则保留小数点后一位小数。 假设用户调用接口，请求历史 30 天的气象结果，需要请求 6 个变量，则理论用量为 （30*6*96）/（14*10*96），向上取整保留一位小数为1.3。
        /// </summary>
        [XmlElement("quota_cost")]
        public string QuotaCost { get; set; }

        /// <summary>
        /// 预测的气象参数列表
        /// </summary>
        [XmlArray("weather_variables_list")]
        [XmlArrayItem("weather_variables")]
        public List<WeatherVariables> WeatherVariablesList { get; set; }
    }
}
