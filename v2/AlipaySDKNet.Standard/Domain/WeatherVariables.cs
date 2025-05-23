using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeatherVariables Data Structure.
    /// </summary>
    [Serializable]
    public class WeatherVariables : AopObject
    {
        /// <summary>
        /// 总云量，单位%
        /// </summary>
        [XmlElement("cloud_cover")]
        public string CloudCover { get; set; }

        /// <summary>
        /// 高云量，单位 %
        /// </summary>
        [XmlElement("cloud_cover_high")]
        public string CloudCoverHigh { get; set; }

        /// <summary>
        /// 低云量，单位 %
        /// </summary>
        [XmlElement("cloud_cover_low")]
        public string CloudCoverLow { get; set; }

        /// <summary>
        /// 中云量，单位 %
        /// </summary>
        [XmlElement("cloud_cover_mid")]
        public string CloudCoverMid { get; set; }

        /// <summary>
        /// 地面两米处的露点温度，单位 摄氏度
        /// </summary>
        [XmlElement("dew_point_2m")]
        public string DewPoint2m { get; set; }

        /// <summary>
        /// 散射辐照 ，单位W/m^2
        /// </summary>
        [XmlElement("diffuse_radiation")]
        public string DiffuseRadiation { get; set; }

        /// <summary>
        /// 直接法向量辐照,单位 W/m^2
        /// </summary>
        [XmlElement("direct_normal_irradiance")]
        public string DirectNormalIrradiance { get; set; }

        /// <summary>
        /// 直接辐照, W/m^2
        /// </summary>
        [XmlElement("direct_radiation")]
        public string DirectRadiation { get; set; }

        /// <summary>
        /// 降雨概率（未来一小时）（降雨量大于0.1mm）单位 %
        /// </summary>
        [XmlElement("precipitation_probability")]
        public string PrecipitationProbability { get; set; }

        /// <summary>
        /// 海平面大气压，单位hPa
        /// </summary>
        [XmlElement("pressure_msl")]
        public string PressureMsl { get; set; }

        /// <summary>
        /// 地面两米处的相对空气湿度，单位 %
        /// </summary>
        [XmlElement("relative_humidity_2m")]
        public string RelativeHumidity2m { get; set; }

        /// <summary>
        /// 短波辐照，单位 W/m^2
        /// </summary>
        [XmlElement("shortwave_radiation")]
        public string ShortwaveRadiation { get; set; }

        /// <summary>
        /// 地表大气压，单位hPa
        /// </summary>
        [XmlElement("surface_pressure")]
        public string SurfacePressure { get; set; }

        /// <summary>
        /// 地面两米处的空气温度, 单位 摄氏度
        /// </summary>
        [XmlElement("temperature_2m")]
        public string Temperature2m { get; set; }

        /// <summary>
        /// 气象变量的日期
        /// </summary>
        [XmlElement("variable_date")]
        public string VariableDate { get; set; }

        /// <summary>
        /// 地面10米处风向，单位 °
        /// </summary>
        [XmlElement("wind_direction_10m")]
        public string WindDirection10m { get; set; }

        /// <summary>
        /// 地面 120 米处风向，单位 °
        /// </summary>
        [XmlElement("wind_direction_120m")]
        public string WindDirection120m { get; set; }

        /// <summary>
        /// 地面80米处风向，单位°
        /// </summary>
        [XmlElement("wind_direction_80m")]
        public string WindDirection80m { get; set; }

        /// <summary>
        /// 地面十米处风速，单位 km/h
        /// </summary>
        [XmlElement("wind_speed_10m")]
        public string WindSpeed10m { get; set; }

        /// <summary>
        /// 地面 120 米处风速，单位km/h
        /// </summary>
        [XmlElement("wind_speed_120m")]
        public string WindSpeed120m { get; set; }

        /// <summary>
        /// 地面80米处风速，单位 km/h
        /// </summary>
        [XmlElement("wind_speed_80m")]
        public string WindSpeed80m { get; set; }
    }
}
