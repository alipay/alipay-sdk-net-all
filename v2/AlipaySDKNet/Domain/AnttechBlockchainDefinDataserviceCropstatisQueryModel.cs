using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropstatisQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceCropstatisQueryModel : AopObject
    {
        /// <summary>
        /// 作物编码条件汇总
        /// </summary>
        [XmlElement("crop_code")]
        public string CropCode { get; set; }

        /// <summary>
        /// 作物长势等级条件汇总
        /// </summary>
        [XmlElement("growth_strength")]
        public long GrowthStrength { get; set; }

        /// <summary>
        /// 是否有墒情/长势/气候等风险
        /// </summary>
        [XmlElement("is_certain_risk")]
        public bool IsCertainRisk { get; set; }

        /// <summary>
        /// 长势是否预警条件汇总
        /// </summary>
        [XmlElement("is_growth_warn")]
        public bool IsGrowthWarn { get; set; }

        /// <summary>
        /// 是否收割完成条件汇总
        /// </summary>
        [XmlElement("is_harvested")]
        public bool IsHarvested { get; set; }

        /// <summary>
        /// 是否高温风险
        /// </summary>
        [XmlElement("is_high_temperature_risk")]
        public bool IsHighTemperatureRisk { get; set; }

        /// <summary>
        /// 是否低温风险
        /// </summary>
        [XmlElement("is_low_temperature_risk")]
        public bool IsLowTemperatureRisk { get; set; }

        /// <summary>
        /// 是否暴雨风险
        /// </summary>
        [XmlElement("is_rainstorm_risk")]
        public bool IsRainstormRisk { get; set; }

        /// <summary>
        /// 是否墒情风险
        /// </summary>
        [XmlElement("is_soil_moisture_risk")]
        public bool IsSoilMoistureRisk { get; set; }

        /// <summary>
        /// 当为true时，返回每个作物类型对应的地块编码列表。考虑到性能，不必要时建议设置为false。
        /// </summary>
        [XmlElement("need_region_codes")]
        public bool NeedRegionCodes { get; set; }

        /// <summary>
        /// 区块编码列表
        /// </summary>
        [XmlArray("region_codes")]
        [XmlArrayItem("string")]
        public List<string> RegionCodes { get; set; }

        /// <summary>
        /// 区块分组编码
        /// </summary>
        [XmlElement("region_group_code")]
        public string RegionGroupCode { get; set; }
    }
}
