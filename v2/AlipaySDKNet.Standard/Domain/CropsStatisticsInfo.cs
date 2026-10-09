using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsStatisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsStatisticsInfo : AopObject
    {
        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("addition_info")]
        public string AdditionInfo { get; set; }

        /// <summary>
        /// 作物编码
        /// </summary>
        [XmlElement("crop_code")]
        public string CropCode { get; set; }

        /// <summary>
        /// 干旱风险地块数
        /// </summary>
        [XmlElement("drought_risk_plot_count")]
        public long DroughtRiskPlotCount { get; set; }

        /// <summary>
        /// 作物预估收割最大时间，YYYYMMDD
        /// </summary>
        [XmlElement("estimate_harvest_time_max")]
        public string EstimateHarvestTimeMax { get; set; }

        /// <summary>
        /// 作物预估收割最小时间，YYYYMMDD
        /// </summary>
        [XmlElement("estimate_harvest_time_min")]
        public string EstimateHarvestTimeMin { get; set; }

        /// <summary>
        /// 长势一般面积
        /// </summary>
        [XmlElement("growth_general_area_sum")]
        public string GrowthGeneralAreaSum { get; set; }

        /// <summary>
        /// 长势一般地块数
        /// </summary>
        [XmlElement("growth_general_plot_count")]
        public long GrowthGeneralPlotCount { get; set; }

        /// <summary>
        /// 长势较强面积
        /// </summary>
        [XmlElement("growth_stronger_area_sum")]
        public string GrowthStrongerAreaSum { get; set; }

        /// <summary>
        /// 长势较强地块数
        /// </summary>
        [XmlElement("growth_stronger_plot_count")]
        public long GrowthStrongerPlotCount { get; set; }

        /// <summary>
        /// 长势极强面积
        /// </summary>
        [XmlElement("growth_strongest_area_sum")]
        public string GrowthStrongestAreaSum { get; set; }

        /// <summary>
        /// 长势极强地块数
        /// </summary>
        [XmlElement("growth_strongest_plot_count")]
        public long GrowthStrongestPlotCount { get; set; }

        /// <summary>
        /// 长势较弱面积
        /// </summary>
        [XmlElement("growth_weaker_area_sum")]
        public string GrowthWeakerAreaSum { get; set; }

        /// <summary>
        /// 长势较弱地块数
        /// </summary>
        [XmlElement("growth_weaker_plot_count")]
        public long GrowthWeakerPlotCount { get; set; }

        /// <summary>
        /// 长势极弱种植面积
        /// </summary>
        [XmlElement("growth_weakest_area_sum")]
        public string GrowthWeakestAreaSum { get; set; }

        /// <summary>
        /// 长势极弱地块数
        /// </summary>
        [XmlElement("growth_weakest_plot_count")]
        public long GrowthWeakestPlotCount { get; set; }

        /// <summary>
        /// 收割进度值，单位0～1
        /// </summary>
        [XmlElement("harvest_progress_value")]
        public string HarvestProgressValue { get; set; }

        /// <summary>
        /// 已收割总面积
        /// </summary>
        [XmlElement("harvested_area_sum")]
        public string HarvestedAreaSum { get; set; }

        /// <summary>
        /// 高温风险地块数
        /// </summary>
        [XmlElement("high_temp_risk_plot_count")]
        public long HighTempRiskPlotCount { get; set; }

        /// <summary>
        /// 低温风险地块数
        /// </summary>
        [XmlElement("low_temp_risk_plot_count")]
        public long LowTempRiskPlotCount { get; set; }

        /// <summary>
        /// 成熟度达100%的地块数
        /// </summary>
        [XmlElement("maturity_plot_count")]
        public long MaturityPlotCount { get; set; }

        /// <summary>
        /// 未收割总面积，单位亩
        /// </summary>
        [XmlElement("not_harvested_area_sum")]
        public string NotHarvestedAreaSum { get; set; }

        /// <summary>
        /// 作物种植总面积，单位亩
        /// </summary>
        [XmlElement("planting_area_sum")]
        public string PlantingAreaSum { get; set; }

        /// <summary>
        /// 地块总面积
        /// </summary>
        [XmlElement("plot_area_sum")]
        public string PlotAreaSum { get; set; }

        /// <summary>
        /// 地块数量
        /// </summary>
        [XmlElement("plot_count")]
        public long PlotCount { get; set; }

        /// <summary>
        /// 暴风雨风险地块数
        /// </summary>
        [XmlElement("rainstorm_risk_plot_count")]
        public long RainstormRiskPlotCount { get; set; }

        /// <summary>
        /// 地块编码列表
        /// </summary>
        [XmlArray("region_codes")]
        [XmlArrayItem("string")]
        public List<string> RegionCodes { get; set; }

        /// <summary>
        /// 土壤墒情风险地块数
        /// </summary>
        [XmlElement("soil_moisture_risk_plot_count")]
        public long SoilMoistureRiskPlotCount { get; set; }

        /// <summary>
        /// 总面积，单位亩
        /// </summary>
        [XmlElement("total_area_sum")]
        public string TotalAreaSum { get; set; }

        /// <summary>
        /// 预计总产量，单位KG
        /// </summary>
        [XmlElement("total_yield_sum")]
        public string TotalYieldSum { get; set; }
    }
}
