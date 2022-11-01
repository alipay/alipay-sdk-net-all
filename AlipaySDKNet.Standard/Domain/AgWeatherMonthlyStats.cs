using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgWeatherMonthlyStats Data Structure.
    /// </summary>
    [Serializable]
    public class AgWeatherMonthlyStats : AopObject
    {
        /// <summary>
        /// 累计降水-月度距平值，单位mm
        /// </summary>
        [XmlElement("acc_precipitation_anomaly")]
        public string AccPrecipitationAnomaly { get; set; }

        /// <summary>
        /// 累计降水-历史月平均值，单位mm
        /// </summary>
        [XmlElement("acc_precipitation_month")]
        public string AccPrecipitationMonth { get; set; }

        /// <summary>
        /// 累计降水-本年度月度值，单位mm
        /// </summary>
        [XmlElement("acc_precipitation_year")]
        public string AccPrecipitationYear { get; set; }

        /// <summary>
        /// 平均温度-月度距平值，单位摄氏度
        /// </summary>
        [XmlElement("avg_temperature_anomaly")]
        public string AvgTemperatureAnomaly { get; set; }

        /// <summary>
        /// 平均温度-历史月平均值，单位摄氏度
        /// </summary>
        [XmlElement("avg_temperature_month")]
        public string AvgTemperatureMonth { get; set; }

        /// <summary>
        /// 平均温度-本年度月度值，单位摄氏度
        /// </summary>
        [XmlElement("avg_temperature_year")]
        public string AvgTemperatureYear { get; set; }

        /// <summary>
        /// 数据生产日期，YYYYMMDD
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 土壤湿度-月度距平值，单位百分比
        /// </summary>
        [XmlElement("soil_moisture_anomaly")]
        public string SoilMoistureAnomaly { get; set; }

        /// <summary>
        /// 土壤湿度-历史月平均值，单位百分比
        /// </summary>
        [XmlElement("soil_moisture_month")]
        public string SoilMoistureMonth { get; set; }

        /// <summary>
        /// 土壤湿度-本年度月度值，单位百分比
        /// </summary>
        [XmlElement("soil_moisture_year")]
        public string SoilMoistureYear { get; set; }

        /// <summary>
        /// 数据更新日期，YYYYMMDD
        /// </summary>
        [XmlElement("update_date")]
        public string UpdateDate { get; set; }

        /// <summary>
        /// 风速-月度距平值，单位米/秒
        /// </summary>
        [XmlElement("wind_speed_anomaly")]
        public string WindSpeedAnomaly { get; set; }

        /// <summary>
        /// 风速-历史月平均值，单位米/秒
        /// </summary>
        [XmlElement("wind_speed_month")]
        public string WindSpeedMonth { get; set; }

        /// <summary>
        /// 风速-本年度月度值，单位米/秒
        /// </summary>
        [XmlElement("wind_speed_year")]
        public string WindSpeedYear { get; set; }
    }
}
