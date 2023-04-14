using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsHarvestForecastInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsHarvestForecastInfo : AopObject
    {
        /// <summary>
        /// 数据生产日期，YYYYMMDD
        /// </summary>
        [XmlElement("actual_date")]
        public string ActualDate { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("addition_info")]
        public string AdditionInfo { get; set; }

        /// <summary>
        /// 数据生产时间，YYYYMMDD
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 作物编码
        /// </summary>
        [XmlElement("crop_code")]
        public string CropCode { get; set; }

        /// <summary>
        /// 作物预估收割时间，YYYYMMDD
        /// </summary>
        [XmlElement("estimate_harvest_time")]
        public string EstimateHarvestTime { get; set; }

        /// <summary>
        /// 是否到收割时间
        /// </summary>
        [XmlElement("is_harvest_time")]
        public bool IsHarvestTime { get; set; }

        /// <summary>
        /// 成熟度，值域0～1
        /// </summary>
        [XmlElement("maturity")]
        public string Maturity { get; set; }
    }
}
