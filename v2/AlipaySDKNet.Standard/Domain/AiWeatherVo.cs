using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AiWeatherVo Data Structure.
    /// </summary>
    [Serializable]
    public class AiWeatherVo : AopObject
    {
        /// <summary>
        /// 空气质量情况
        /// </summary>
        [XmlElement("aqi_quality")]
        public string AqiQuality { get; set; }

        /// <summary>
        /// 空气质量分数
        /// </summary>
        [XmlElement("aqi_score")]
        public string AqiScore { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 湿度（%）
        /// </summary>
        [XmlElement("humidity")]
        public string Humidity { get; set; }

        /// <summary>
        /// 温度（摄氏度)
        /// </summary>
        [XmlElement("temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// 今天最高温度（摄氏度）
        /// </summary>
        [XmlElement("today_highest_temperature")]
        public string TodayHighestTemperature { get; set; }

        /// <summary>
        /// 今天最低温度（摄氏度）
        /// </summary>
        [XmlElement("today_lowest_temperature")]
        public string TodayLowestTemperature { get; set; }

        /// <summary>
        /// 天气情况描述
        /// </summary>
        [XmlElement("weather")]
        public string Weather { get; set; }

        /// <summary>
        /// 风向
        /// </summary>
        [XmlElement("wind_direction")]
        public string WindDirection { get; set; }

        /// <summary>
        /// 风的级数
        /// </summary>
        [XmlElement("wind_evel")]
        public string WindEvel { get; set; }
    }
}
