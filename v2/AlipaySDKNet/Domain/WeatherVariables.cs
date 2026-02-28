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
        /// 体感温度 °C
        /// </summary>
        [XmlElement("apparent_temperature")]
        public string ApparentTemperature { get; set; }

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
        [XmlElement("dew_point_2_m")]
        public string DewPoint2M { get; set; }

        /// <summary>
        /// 地面两米处的露点温度，单位 摄氏度 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("dew_point_2m")]
        public string DewPoint2m { get; set; }

        /// <summary>
        /// 散射辐照 ，单位W/m^2
        /// </summary>
        [XmlElement("diffuse_radiation")]
        public string DiffuseRadiation { get; set; }

        /// <summary>
        /// 散射辐照瞬时值 W/m^2
        /// </summary>
        [XmlElement("diffuse_radiation_instant")]
        public string DiffuseRadiationInstant { get; set; }

        /// <summary>
        /// 直接法向量辐照,单位 W/m^2
        /// </summary>
        [XmlElement("direct_normal_irradiance")]
        public string DirectNormalIrradiance { get; set; }

        /// <summary>
        /// 直接法向量辐照瞬时值 W/m^2
        /// </summary>
        [XmlElement("direct_normal_irradiance_instant")]
        public string DirectNormalIrradianceInstant { get; set; }

        /// <summary>
        /// 直接辐照, W/m^2
        /// </summary>
        [XmlElement("direct_radiation")]
        public string DirectRadiation { get; set; }

        /// <summary>
        /// 直接辐照瞬时值 W/m^2
        /// </summary>
        [XmlElement("direct_radiation_instant")]
        public string DirectRadiationInstant { get; set; }

        /// <summary>
        /// 降水量（包含所有形式） mm
        /// </summary>
        [XmlElement("precipitation")]
        public string Precipitation { get; set; }

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
        /// 降雨量 mm
        /// </summary>
        [XmlElement("rain")]
        public string Rain { get; set; }

        /// <summary>
        /// 地面两米处的相对空气湿度，单位 %
        /// </summary>
        [XmlElement("relative_humidity_2_m")]
        public string RelativeHumidity2M { get; set; }

        /// <summary>
        /// 地面两米处的相对空气湿度，单位 % 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("relative_humidity_2m")]
        public string RelativeHumidity2m { get; set; }

        /// <summary>
        /// 短波辐照，单位 W/m^2
        /// </summary>
        [XmlElement("shortwave_radiation")]
        public string ShortwaveRadiation { get; set; }

        /// <summary>
        /// 短波辐照瞬时值 W/m^2
        /// </summary>
        [XmlElement("shortwave_radiation_instant")]
        public string ShortwaveRadiationInstant { get; set; }

        /// <summary>
        /// 降雪量 cm
        /// </summary>
        [XmlElement("snowfall")]
        public string Snowfall { get; set; }

        /// <summary>
        /// 地表大气压，单位hPa
        /// </summary>
        [XmlElement("surface_pressure")]
        public string SurfacePressure { get; set; }

        /// <summary>
        /// 地面两米处的空气温度, 单位 摄氏度
        /// </summary>
        [XmlElement("temperature_2_m")]
        public string Temperature2M { get; set; }

        /// <summary>
        /// 地面两米处的空气温度, 单位 摄氏度 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("temperature_2m")]
        public string Temperature2m { get; set; }

        /// <summary>
        /// 气象变量的日期
        /// </summary>
        [XmlElement("variable_date")]
        public string VariableDate { get; set; }

        /// <summary>
        /// 天气代码
        /// </summary>
        [XmlElement("weather_code")]
        public string WeatherCode { get; set; }

        /// <summary>
        /// 地面10米处风向，单位 °
        /// </summary>
        [XmlElement("wind_direction_10_m")]
        public string WindDirection10M { get; set; }

        /// <summary>
        /// 地面10米处风向，单位 ° 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("wind_direction_10m")]
        public string WindDirection10m { get; set; }

        /// <summary>
        /// 地面 120 米处风向，单位 °
        /// </summary>
        [XmlElement("wind_direction_120_m")]
        public string WindDirection120M { get; set; }

        /// <summary>
        /// 地面 120 米处风向，单位 ° 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("wind_direction_120m")]
        public string WindDirection120m { get; set; }

        /// <summary>
        /// 地面 180 米处风向 °
        /// </summary>
        [XmlElement("wind_direction_180_m")]
        public string WindDirection180M { get; set; }

        /// <summary>
        /// 地面80米处风向，单位°
        /// </summary>
        [XmlElement("wind_direction_80_m")]
        public string WindDirection80M { get; set; }

        /// <summary>
        /// 地面80米处风向，单位° 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("wind_direction_80m")]
        public string WindDirection80m { get; set; }

        /// <summary>
        /// 地面十米处风速，单位 m/s
        /// </summary>
        [XmlElement("wind_speed_10_m")]
        public string WindSpeed10M { get; set; }

        /// <summary>
        /// 地面十米处风速，单位 m/s 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("wind_speed_10m")]
        public string WindSpeed10m { get; set; }

        /// <summary>
        /// 地面 120 米处风速，单位m/s
        /// </summary>
        [XmlElement("wind_speed_120_m")]
        public string WindSpeed120M { get; set; }

        /// <summary>
        /// 地面 120 米处风速，单位m/s 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("wind_speed_120m")]
        public string WindSpeed120m { get; set; }

        /// <summary>
        /// 地面 180 米处风速 m/s
        /// </summary>
        [XmlElement("wind_speed_180_m")]
        public string WindSpeed180M { get; set; }

        /// <summary>
        /// 地面80米处风速，单位 m/s
        /// </summary>
        [XmlElement("wind_speed_80_m")]
        public string WindSpeed80M { get; set; }

        /// <summary>
        /// 地面80米处风速，单位 m/s 当前字段已废弃(网关SDK字段映射不一致)
        /// </summary>
        [XmlElement("wind_speed_80m")]
        public string WindSpeed80m { get; set; }
    }
}
