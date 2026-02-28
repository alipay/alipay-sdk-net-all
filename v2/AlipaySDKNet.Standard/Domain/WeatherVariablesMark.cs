using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeatherVariablesMark Data Structure.
    /// </summary>
    [Serializable]
    public class WeatherVariablesMark : AopObject
    {
        /// <summary>
        /// 体感温度
        /// </summary>
        [XmlElement("apparent_temperature")]
        public bool ApparentTemperature { get; set; }

        /// <summary>
        /// 总云量的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("cloud_cover")]
        public bool CloudCover { get; set; }

        /// <summary>
        /// 高云量的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("cloud_cover_high")]
        public bool CloudCoverHigh { get; set; }

        /// <summary>
        /// 低云量的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("cloud_cover_low")]
        public bool CloudCoverLow { get; set; }

        /// <summary>
        /// 中云量的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("cloud_cover_mid")]
        public bool CloudCoverMid { get; set; }

        /// <summary>
        /// 地面两米处的露点温度的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("dew_point_2m")]
        public bool DewPoint2m { get; set; }

        /// <summary>
        /// 散射辐照的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("diffuse_radiation")]
        public bool DiffuseRadiation { get; set; }

        /// <summary>
        /// 散射辐照瞬时值
        /// </summary>
        [XmlElement("diffuse_radiation_instant")]
        public bool DiffuseRadiationInstant { get; set; }

        /// <summary>
        /// 直接法向量辐照的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("direct_normal_irradiance")]
        public bool DirectNormalIrradiance { get; set; }

        /// <summary>
        /// 直接法向量辐照瞬时值
        /// </summary>
        [XmlElement("direct_normal_irradiance_instant")]
        public bool DirectNormalIrradianceInstant { get; set; }

        /// <summary>
        /// 直接辐照的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("direct_radiation")]
        public bool DirectRadiation { get; set; }

        /// <summary>
        /// 直接辐照瞬时值
        /// </summary>
        [XmlElement("direct_radiation_instant")]
        public bool DirectRadiationInstant { get; set; }

        /// <summary>
        /// 降水量（包含所有形式）
        /// </summary>
        [XmlElement("precipitation")]
        public bool Precipitation { get; set; }

        /// <summary>
        /// 降雨概率的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("precipitation_probability")]
        public bool PrecipitationProbability { get; set; }

        /// <summary>
        /// 海平面大气压的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("pressure_msl")]
        public bool PressureMsl { get; set; }

        /// <summary>
        /// 降雨量
        /// </summary>
        [XmlElement("rain")]
        public bool Rain { get; set; }

        /// <summary>
        /// 地面两米处的相对空气湿度标记，true表示查询，默认false
        /// </summary>
        [XmlElement("relative_humidity_2m")]
        public bool RelativeHumidity2m { get; set; }

        /// <summary>
        /// 短波辐照的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("shortwave_radiation")]
        public bool ShortwaveRadiation { get; set; }

        /// <summary>
        /// 短波辐照瞬时值
        /// </summary>
        [XmlElement("shortwave_radiation_instant")]
        public bool ShortwaveRadiationInstant { get; set; }

        /// <summary>
        /// 降雪量
        /// </summary>
        [XmlElement("snowfall")]
        public bool Snowfall { get; set; }

        /// <summary>
        /// 地表大气压的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("surface_pressure")]
        public bool SurfacePressure { get; set; }

        /// <summary>
        /// 地面两米处的空气温度标记，true表示查询，默认false
        /// </summary>
        [XmlElement("temperature_2m")]
        public bool Temperature2m { get; set; }

        /// <summary>
        /// 天气代码
        /// </summary>
        [XmlElement("weather_code")]
        public bool WeatherCode { get; set; }

        /// <summary>
        /// 地面10米处风向标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_direction_10m")]
        public bool WindDirection10m { get; set; }

        /// <summary>
        /// 地面120米处风向标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_direction_120m")]
        public bool WindDirection120m { get; set; }

        /// <summary>
        /// 地面 180 米处风向
        /// </summary>
        [XmlElement("wind_direction_180m")]
        public bool WindDirection180m { get; set; }

        /// <summary>
        /// 地面80米处风向的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_direction_80m")]
        public bool WindDirection80m { get; set; }

        /// <summary>
        /// 地面10米处风速标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_speed_10m")]
        public bool WindSpeed10m { get; set; }

        /// <summary>
        /// 地面120米处风速标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_speed_120m")]
        public bool WindSpeed120m { get; set; }

        /// <summary>
        /// 地面 180 米处风速
        /// </summary>
        [XmlElement("wind_speed_180m")]
        public bool WindSpeed180m { get; set; }

        /// <summary>
        /// 地面80米处风速的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_speed_80m")]
        public bool WindSpeed80m { get; set; }
    }
}
