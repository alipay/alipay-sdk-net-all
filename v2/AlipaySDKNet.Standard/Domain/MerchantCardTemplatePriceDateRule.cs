using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplatePriceDateRule Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplatePriceDateRule : AopObject
    {
        /// <summary>
        /// 日期价格规则结束日期，格式为yyyy-MM-dd，不能早于开始日期。
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 每天价格时段的结束时间，格式为HH:mm:ss。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间与开始时间在同一天或次日。
        /// </summary>
        [XmlElement("end_time_type")]
        public string EndTimeType { get; set; }

        /// <summary>
        /// 该时段原价，单位为分；如传入，不得小于售价。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 该时段售价，单位为分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 日期价格规则开始日期，格式为yyyy-MM-dd。
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 每天价格时段的开始时间，格式为HH:mm:ss。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
