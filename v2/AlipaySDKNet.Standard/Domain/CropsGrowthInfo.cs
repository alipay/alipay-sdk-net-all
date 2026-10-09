using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsGrowthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsGrowthInfo : AopObject
    {
        /// <summary>
        /// 数据实际日期，YYYYMMDD
        /// </summary>
        [XmlElement("actual_date")]
        public string ActualDate { get; set; }

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
        /// 长势一般面积，单位亩
        /// </summary>
        [XmlElement("general_area")]
        public string GeneralArea { get; set; }

        /// <summary>
        /// 长势强弱，值域1～5
        /// </summary>
        [XmlElement("strength")]
        public long Strength { get; set; }

        /// <summary>
        /// 长势较强面积，单位亩
        /// </summary>
        [XmlElement("stronger_area")]
        public string StrongerArea { get; set; }

        /// <summary>
        /// 长势极强面积，单位亩
        /// </summary>
        [XmlElement("strongest_area")]
        public string StrongestArea { get; set; }

        /// <summary>
        /// 长势预警值，值域-1～0
        /// </summary>
        [XmlElement("warn")]
        public string Warn { get; set; }

        /// <summary>
        /// 长势较弱面积，单位亩
        /// </summary>
        [XmlElement("weaker_area")]
        public string WeakerArea { get; set; }

        /// <summary>
        /// 长势极弱面积，单位亩
        /// </summary>
        [XmlElement("weakest_area")]
        public string WeakestArea { get; set; }
    }
}
