using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceRegiongroupMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceRegiongroupMatchModel : AopObject
    {
        /// <summary>
        /// 作物编码条件匹配
        /// </summary>
        [XmlElement("crop_code")]
        public string CropCode { get; set; }

        /// <summary>
        /// 作物长势等级条件匹配
        /// </summary>
        [XmlElement("growth_strength")]
        public long GrowthStrength { get; set; }

        /// <summary>
        /// 是否有上述风险之一
        /// </summary>
        [XmlElement("is_certain_risk")]
        public bool IsCertainRisk { get; set; }

        /// <summary>
        /// 长势是否预警条件筛选
        /// </summary>
        [XmlElement("is_growth_warn")]
        public bool IsGrowthWarn { get; set; }

        /// <summary>
        /// 是否收割完成条件匹配
        /// </summary>
        [XmlElement("is_harvested")]
        public bool IsHarvested { get; set; }

        /// <summary>
        /// 是否高温风险条件匹配
        /// </summary>
        [XmlElement("is_high_temperature_risk")]
        public bool IsHighTemperatureRisk { get; set; }

        /// <summary>
        /// 是否低温风险条件匹配
        /// </summary>
        [XmlElement("is_low_temperature_risk")]
        public bool IsLowTemperatureRisk { get; set; }

        /// <summary>
        /// 是否暴雨风险条件匹配
        /// </summary>
        [XmlElement("is_rainstorm_risk")]
        public bool IsRainstormRisk { get; set; }

        /// <summary>
        /// 是否墒情风险条件匹配
        /// </summary>
        [XmlElement("is_soil_moisture_risk")]
        public bool IsSoilMoistureRisk { get; set; }

        /// <summary>
        /// 仅需要各作物匹配数，此时返回玉米/大豆/水稻的各自匹配编组数
        /// </summary>
        [XmlElement("need_crops_count_only")]
        public bool NeedCropsCountOnly { get; set; }

        /// <summary>
        /// 待匹配的区块分组编码列表
        /// </summary>
        [XmlArray("region_group_codes")]
        [XmlArrayItem("string")]
        public List<string> RegionGroupCodes { get; set; }
    }
}
