using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechLoadForecastQueryResponse.
    /// </summary>
    public class DatadigitalAnttechLoadForecastQueryResponse : AopResponse
    {
        /// <summary>
        /// 负荷预测数据信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("energy_forecast_info")]
        public List<EnergyForecastInfo> Data { get; set; }

        /// <summary>
        /// 消耗的token数量。
        /// </summary>
        [XmlElement("quota_cost")]
        public string QuotaCost { get; set; }
    }
}
