using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DentalInquiryArchivesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DentalInquiryArchivesInfo : AopObject
    {
        /// <summary>
        /// 记录医生提供的病症信息
        /// </summary>
        [XmlArray("diseases")]
        [XmlArrayItem("dental_inquiry_archives_disease_info")]
        public List<DentalInquiryArchivesDiseaseInfo> Diseases { get; set; }

        /// <summary>
        /// 医生头像图片链接
        /// </summary>
        [XmlElement("doctor_avatar")]
        public string DoctorAvatar { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 记录医生医嘱
        /// </summary>
        [XmlElement("doctor_suggestion")]
        public string DoctorSuggestion { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 用于描述用户健康等级
        /// </summary>
        [XmlElement("health_level")]
        public string HealthLevel { get; set; }

        /// <summary>
        /// 描述用户健康分数
        /// </summary>
        [XmlElement("health_score")]
        public string HealthScore { get; set; }

        /// <summary>
        /// 用于记录医生的就诊时间
        /// </summary>
        [XmlElement("inquiry_time")]
        public string InquiryTime { get; set; }

        /// <summary>
        /// 商家侧医生编号
        /// </summary>
        [XmlElement("out_doctor_id")]
        public string OutDoctorId { get; set; }

        /// <summary>
        /// 记录商家的门店ID号
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }
    }
}
