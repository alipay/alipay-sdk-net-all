using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsYieldForecastInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsYieldForecastInfo : AopObject
    {
        /// <summary>
        /// 数据实际日期，YYYYMMDD
        /// </summary>
        [XmlElement("actual_date")]
        public string ActualDate { get; set; }

        /// <summary>
        /// 数据实际年份，YYYY
        /// </summary>
        [XmlElement("actual_year")]
        public string ActualYear { get; set; }

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
        /// 亩产量，单位KG/亩
        /// </summary>
        [XmlElement("per_unit_yield")]
        public string PerUnitYield { get; set; }

        /// <summary>
        /// 总产量，单位KG
        /// </summary>
        [XmlElement("total_yield")]
        public string TotalYield { get; set; }
    }
}
