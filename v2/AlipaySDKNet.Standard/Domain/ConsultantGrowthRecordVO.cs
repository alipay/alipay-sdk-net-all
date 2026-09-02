using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultantGrowthRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultantGrowthRecordVO : AopObject
    {
        /// <summary>
        /// 月龄（由出生日期与recordDate计算）
        /// </summary>
        [XmlElement("age_in_months")]
        public long AgeInMonths { get; set; }

        /// <summary>
        /// BMI指数，保留两位小数
        /// </summary>
        [XmlElement("bmi")]
        public string Bmi { get; set; }

        /// <summary>
        /// 身高，单位：厘米（cm），保留两位小数
        /// </summary>
        [XmlElement("growth_height")]
        public string GrowthHeight { get; set; }

        /// <summary>
        /// 体重，单位：千克（kg），保留两位小数
        /// </summary>
        [XmlElement("growth_weight")]
        public string GrowthWeight { get; set; }

        /// <summary>
        /// 头围，单位：厘米（cm），3岁以下，保留两位小数
        /// </summary>
        [XmlElement("head_circumference")]
        public string HeadCircumference { get; set; }

        /// <summary>
        /// 记录业务键（同时作为该记录对应 AI 解读的 interpBizId）
        /// </summary>
        [XmlElement("record_biz_id")]
        public string RecordBizId { get; set; }

        /// <summary>
        /// 记录日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }
    }
}
