using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CropsHarvestProgressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CropsHarvestProgressInfo : AopObject
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
        /// 收割进度值，值域0～1
        /// </summary>
        [XmlElement("harvest_progress_value")]
        public string HarvestProgressValue { get; set; }

        /// <summary>
        /// 已收割面积，单位亩
        /// </summary>
        [XmlElement("harvested_area")]
        public string HarvestedArea { get; set; }

        /// <summary>
        /// 总面积，单位亩
        /// </summary>
        [XmlElement("total_area")]
        public string TotalArea { get; set; }
    }
}
