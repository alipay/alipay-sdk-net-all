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
        /// 直接法向量辐照的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("direct_normal_irradiance")]
        public bool DirectNormalIrradiance { get; set; }

        /// <summary>
        /// 直接辐照的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("direct_radiation")]
        public bool DirectRadiation { get; set; }

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
        /// 地面80米处风速的标记，true表示查询，默认false
        /// </summary>
        [XmlElement("wind_speed_80m")]
        public bool WindSpeed80m { get; set; }
    }
}
