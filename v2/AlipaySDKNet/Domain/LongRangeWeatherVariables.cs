using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LongRangeWeatherVariables Data Structure.
    /// </summary>
    [Serializable]
    public class LongRangeWeatherVariables : AopObject
    {
        /// <summary>
        /// 体感温度，表示人体实际感受到的温度，单位：°C。
        /// </summary>
        [XmlElement("apparent_temperature")]
        public string ApparentTemperature { get; set; }

        /// <summary>
        /// 云量，单位：%
        /// </summary>
        [XmlElement("cloud_cover")]
        public string CloudCover { get; set; }

        /// <summary>
        /// 表示地面二米处的露点温度，参数类型为 string，单位：°C。
        /// </summary>
        [XmlElement("dew_point_2_m")]
        public string DewPoint2M { get; set; }

        /// <summary>
        /// 散射辐射，单位：W/m2
        /// </summary>
        [XmlElement("diffuse_radiation")]
        public string DiffuseRadiation { get; set; }

        /// <summary>
        /// 散射辐射瞬时值，表示当前时刻的散射短波辐射强度，单位：W/m2。
        /// </summary>
        [XmlElement("diffuse_radiation_instant")]
        public string DiffuseRadiationInstant { get; set; }

        /// <summary>
        /// 直接辐射，表示来自太阳直射方向的辐射强度，用于描述天气或气象条件中的太阳辐射情况，单位：W/m2。
        /// </summary>
        [XmlElement("direct_radiation")]
        public string DirectRadiation { get; set; }

        /// <summary>
        /// 直接辐射瞬时值，单位：W/m2
        /// </summary>
        [XmlElement("direct_radiation_instant")]
        public string DirectRadiationInstant { get; set; }

        /// <summary>
        /// 降水量，单位：mm
        /// </summary>
        [XmlElement("precipitation")]
        public string Precipitation { get; set; }

        /// <summary>
        /// 海平面气压，单位hPa
        /// </summary>
        [XmlElement("pressure_msl")]
        public string PressureMsl { get; set; }

        /// <summary>
        /// 地面2米处相对湿度，表示距离地面2米高度处空气中水汽含量相对于同温度下饱和水汽含量的百分比，单位：%。
        /// </summary>
        [XmlElement("relative_humidity_2_m")]
        public string RelativeHumidity2M { get; set; }

        /// <summary>
        /// 短波辐射，单位：W/m2
        /// </summary>
        [XmlElement("shortwave_radiation")]
        public string ShortwaveRadiation { get; set; }

        /// <summary>
        /// 短波辐射瞬时值，表示当前时刻的短波太阳辐射强度，单位：W/m2。
        /// </summary>
        [XmlElement("shortwave_radiation_instant")]
        public string ShortwaveRadiationInstant { get; set; }

        /// <summary>
        /// 地表气压，表示观测点地表处的大气压力，单位hPa。
        /// </summary>
        [XmlElement("surface_pressure")]
        public string SurfacePressure { get; set; }

        /// <summary>
        /// 地面2米处气温，表示距离地表2米高度处测得的空气温度，单位：°C。
        /// </summary>
        [XmlElement("temperature_2_m")]
        public string Temperature2M { get; set; }

        /// <summary>
        /// 地面2米处最高气温，单位：°C
        /// </summary>
        [XmlElement("temperature_max_2_m")]
        public string TemperatureMax2M { get; set; }

        /// <summary>
        /// 地面 2 米处最低气温，单位：°C
        /// </summary>
        [XmlElement("temperature_min_2_m")]
        public string TemperatureMin2M { get; set; }

        /// <summary>
        /// 气象变量的日期
        /// </summary>
        [XmlElement("variable_date")]
        public string VariableDate { get; set; }

        /// <summary>
        /// 天气代码，枚举范围： CLEAR:晴 MAINLY_CLEAR:大部晴朗 PARTLY_CLOUDY:局部多云 OVERCAST:阴/多云 FOG:雾 RIME_FOG:雾凇雾 DRIZZLE_LIGHT:小毛毛雨 DRIZZLE_MODERATE:中等毛毛雨 DRIZZLE_HEAVY:强毛毛雨 FREEZING_DRIZZLE_LIGHT:小冻毛毛雨 FREEZING_DRIZZLE_HEAVY:强冻毛毛雨 RAIN_LIGHT:小雨 RAIN_MODERATE:中雨 RAIN_HEAVY:大雨 FREEZING_RAIN_LIGHT:小冻雨 FREEZING_RAIN_HEAVY:强冻雨 SNOW_LIGHT:小雪 SNOW_MODERATE:中雪 SNOW_HEAVY:大雪 SNOW_GRAINS:雪粒 RAIN_SHOWER_LIGHT:小阵雨 RAIN_SHOWER_MODERATE:中等阵雨 RAIN_SHOWER_HEAVY:强阵雨 SNOW_SHOWER_LIGHT:小阵雪 SNOW_SHOWER_HEAVY:强阵雪 THUNDERSTORM:雷暴 THUNDERSTORM_HAIL_LIGHT:雷暴伴小冰雹 THUNDERSTORM_HAIL_HEAVY:雷暴伴强冰雹 UNKNOWN:未识别/空值
        /// </summary>
        [XmlElement("weather_code")]
        public string WeatherCode { get; set; }

        /// <summary>
        /// 100 米高度风向，表示距地面 100 米高度处的风向，通常以角度表示，单位：°。
        /// </summary>
        [XmlElement("wind_direction_100_m")]
        public string WindDirection100M { get; set; }

        /// <summary>
        /// 10 米高度风向，表示地面以上 10 米处的风向数据，通常以角度表示，单位：°。
        /// </summary>
        [XmlElement("wind_direction_10_m")]
        public string WindDirection10M { get; set; }

        /// <summary>
        /// 表示地面二百米高度处的风向，通常以角度值表示，单位：°。
        /// </summary>
        [XmlElement("wind_direction_200_m")]
        public string WindDirection200M { get; set; }

        /// <summary>
        /// 10米高度阵风风速，表示地面以上10米处短时间内出现的最大风速。
        /// </summary>
        [XmlElement("wind_gusts_10_m")]
        public string WindGusts10M { get; set; }

        /// <summary>
        /// 一百米高度风速，表示距地面一百米高度处的风速数据，单位：m/s。
        /// </summary>
        [XmlElement("wind_speed_100_m")]
        public string WindSpeed100M { get; set; }

        /// <summary>
        /// 10米高度风速，单位：m/s
        /// </summary>
        [XmlElement("wind_speed_10_m")]
        public string WindSpeed10M { get; set; }

        /// <summary>
        /// 200米高度风速，表示距地面200米高度处的风速数据，单位：m/s。
        /// </summary>
        [XmlElement("wind_speed_200_m")]
        public string WindSpeed200M { get; set; }
    }
}
