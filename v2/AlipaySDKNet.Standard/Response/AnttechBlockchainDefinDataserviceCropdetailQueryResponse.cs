using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropdetailQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceCropdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 长势检测10期数据，product_code=1002返回
        /// </summary>
        [XmlArray("growth_infos")]
        [XmlArrayItem("crops_growth_info")]
        public List<CropsGrowthInfo> GrowthInfos { get; set; }

        /// <summary>
        /// 气象历史12月信息，product_type=1010返回
        /// </summary>
        [XmlArray("month_weather_infos")]
        [XmlArrayItem("ag_weather_monthly_stats")]
        public List<AgWeatherMonthlyStats> MonthWeatherInfos { get; set; }

        /// <summary>
        /// 土壤墒情七天预测，product_code=1005返回
        /// </summary>
        [XmlArray("soil_moisture_infos")]
        [XmlArrayItem("crops_soil_moisture_info")]
        public List<CropsSoilMoistureInfo> SoilMoistureInfos { get; set; }

        /// <summary>
        /// 气象灾害历史信息，product_type=1011返回
        /// </summary>
        [XmlElement("weather_disaster_history")]
        public AgWeatherDisasterHistory WeatherDisasterHistory { get; set; }

        /// <summary>
        /// 气象灾害7天预测，product_code=1006返回
        /// </summary>
        [XmlArray("weather_disaster_infos")]
        [XmlArrayItem("ag_weather_disaster_info")]
        public List<AgWeatherDisasterInfo> WeatherDisasterInfos { get; set; }

        /// <summary>
        /// 农业气象7天预测，product_code=1007返回
        /// </summary>
        [XmlArray("weather_forecast_infos")]
        [XmlArrayItem("ag_weather_forecast_info")]
        public List<AgWeatherForecastInfo> WeatherForecastInfos { get; set; }

        /// <summary>
        /// 气象历史50周信息，product_type=1008返回
        /// </summary>
        [XmlArray("week_weather_infos")]
        [XmlArrayItem("ag_weather_weekly_stats")]
        public List<AgWeatherWeeklyStats> WeekWeatherInfos { get; set; }
    }
}
