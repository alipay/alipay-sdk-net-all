using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropbaseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceCropbaseBatchqueryModel : AopObject
    {
        /// <summary>
        /// 根据作物编码条件搜索
        /// </summary>
        [XmlElement("crop_code")]
        public string CropCode { get; set; }

        /// <summary>
        /// 根据作物长势等级条件搜索
        /// </summary>
        [XmlElement("growth_strength")]
        public long GrowthStrength { get; set; }

        /// <summary>
        /// 是否有墒情/长势/气候等风险
        /// </summary>
        [XmlElement("is_certain_risk")]
        public bool IsCertainRisk { get; set; }

        /// <summary>
        /// 长势是否预警条件搜索
        /// </summary>
        [XmlElement("is_growth_warn")]
        public bool IsGrowthWarn { get; set; }

        /// <summary>
        /// 根据是否收割完成条件搜索
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
        /// 当为true时，仅返回地块相关作物编码字段，同时接受页大小开放
        /// </summary>
        [XmlElement("need_crop_only")]
        public bool NeedCropOnly { get; set; }

        /// <summary>
        /// 页码，默认为0
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 区块编码列表，当仅查询作物类别时可以支持大量区域，否则暂限100条明细
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
