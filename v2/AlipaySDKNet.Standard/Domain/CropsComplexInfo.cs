using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsComplexInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsComplexInfo : AopObject
    {
        /// <summary>
        /// 作物编码列表
        /// </summary>
        [XmlArray("crops")]
        [XmlArrayItem("string")]
        public List<string> Crops { get; set; }

        /// <summary>
        /// 作物当期长势信息(1002)
        /// </summary>
        [XmlArray("growth_info")]
        [XmlArrayItem("crops_growth_info")]
        public List<CropsGrowthInfo> GrowthInfo { get; set; }

        /// <summary>
        /// 作物收割预测信息
        /// </summary>
        [XmlArray("harvest_forecast_info")]
        [XmlArrayItem("crops_harvest_forecast_info")]
        public List<CropsHarvestForecastInfo> HarvestForecastInfo { get; set; }

        /// <summary>
        /// 农作物收割进度信息(1014)
        /// </summary>
        [XmlArray("harvest_progress_info")]
        [XmlArrayItem("crops_harvest_progress_info")]
        public List<CropsHarvestProgressInfo> HarvestProgressInfo { get; set; }

        /// <summary>
        /// 作物种植信息(1001)
        /// </summary>
        [XmlArray("planting_info")]
        [XmlArrayItem("crops_planting_info")]
        public List<CropsPlantingInfo> PlantingInfo { get; set; }

        /// <summary>
        /// 地块面积
        /// </summary>
        [XmlElement("plot_area")]
        public string PlotArea { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 土壤墒情信息(1005)
        /// </summary>
        [XmlArray("soil_moisture_info")]
        [XmlArrayItem("crops_soil_moisture_info")]
        public List<CropsSoilMoistureInfo> SoilMoistureInfo { get; set; }

        /// <summary>
        /// 数据更新日期，YYYYMMDD
        /// </summary>
        [XmlElement("update_date")]
        public string UpdateDate { get; set; }

        /// <summary>
        /// 气象灾害预警(1006)
        /// </summary>
        [XmlElement("weather_disaster_info")]
        public AgWeatherDisasterInfo WeatherDisasterInfo { get; set; }

        /// <summary>
        /// 农业气象预报数据(1007)
        /// </summary>
        [XmlElement("weather_forecast_info")]
        public AgWeatherForecastInfo WeatherForecastInfo { get; set; }

        /// <summary>
        /// 作物产量预估(1004)
        /// </summary>
        [XmlArray("yield_forecast_info")]
        [XmlArrayItem("crops_yield_forecast_info")]
        public List<CropsYieldForecastInfo> YieldForecastInfo { get; set; }
    }
}
