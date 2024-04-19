using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateNceeApplySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateNceeApplySyncModel : AopObject
    {
        /// <summary>
        /// 批次
        /// </summary>
        [XmlElement("batch")]
        public string Batch { get; set; }

        /// <summary>
        /// 选科或选测信息
        /// </summary>
        [XmlElement("course")]
        public string Course { get; set; }

        /// <summary>
        /// 专业关注数
        /// </summary>
        [XmlElement("interested_major_num")]
        public long InterestedMajorNum { get; set; }

        /// <summary>
        /// 院校关注数
        /// </summary>
        [XmlElement("interested_school_num")]
        public long InterestedSchoolNum { get; set; }

        /// <summary>
        /// 是否支持一键填报
        /// </summary>
        [XmlElement("one_key_support")]
        public long OneKeySupport { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public long ProvinceCode { get; set; }

        /// <summary>
        /// 志愿表数
        /// </summary>
        [XmlElement("purpose_form_num")]
        public long PurposeFormNum { get; set; }

        /// <summary>
        /// 位次
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 报告数
        /// </summary>
        [XmlElement("report_num")]
        public long ReportNum { get; set; }

        /// <summary>
        /// 高考分数
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 可选数量
        /// </summary>
        [XmlElement("selected_num")]
        public long SelectedNum { get; set; }

        /// <summary>
        /// 科类
        /// </summary>
        [XmlElement("subject")]
        public long Subject { get; set; }

        /// <summary>
        /// 批次总数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 高考年份
        /// </summary>
        [XmlElement("year")]
        public long Year { get; set; }
    }
}
