using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegisterDoctorInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RegisterDoctorInfoDTO : AopObject
    {
        /// <summary>
        /// 挂号医生地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 最早预约时间，全部号源筛选下，消费该字段
        /// </summary>
        [XmlElement("book_date")]
        public string BookDate { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 科室id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 医院行政科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生挂号主页链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 用户当前位置与医院距离，单位:m
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 医生性别
        /// </summary>
        [XmlElement("doctor_gender")]
        public string DoctorGender { get; set; }

        /// <summary>
        /// 平台医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 内部医生id
        /// </summary>
        [XmlElement("doctor_inner_id")]
        public string DoctorInnerId { get; set; }

        /// <summary>
        /// 医生头像
        /// </summary>
        [XmlElement("doctor_logo")]
        public string DoctorLogo { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 最早挂号日期
        /// </summary>
        [XmlElement("earliest_date")]
        public string EarliestDate { get; set; }

        /// <summary>
        /// 医生教学名称
        /// </summary>
        [XmlElement("education_title")]
        public string EducationTitle { get; set; }

        /// <summary>
        /// 医院级别 三甲：THIRD_CLASS 三级：THREE_LEVEL 二级：SECOND_LEVEL 一级：FIRST_LEVEL 社区卫生服务中心：HEALTH_CENTER 其他：OTHER
        /// </summary>
        [XmlElement("hos_grade")]
        public string HosGrade { get; set; }

        /// <summary>
        /// 灵知医院id
        /// </summary>
        [XmlElement("hos_uinq_code")]
        public string HosUinqCode { get; set; }

        /// <summary>
        /// 医生挂号医院地址
        /// </summary>
        [XmlElement("hospital_address")]
        public string HospitalAddress { get; set; }

        /// <summary>
        /// 科室专科复旦top标签
        /// </summary>
        [XmlArray("hospital_dep_feature_tags")]
        [XmlArrayItem("string")]
        public List<string> HospitalDepFeatureTags { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 号源列表
        /// </summary>
        [XmlArray("number_count_list")]
        [XmlArrayItem("register_number_count_d_t_o")]
        public List<RegisterNumberCountDTO> NumberCountList { get; set; }

        /// <summary>
        /// 号源状态
        /// </summary>
        [XmlElement("number_status")]
        public string NumberStatus { get; set; }

        /// <summary>
        /// 平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 医生擅长
        /// </summary>
        [XmlElement("proficiency")]
        public string Proficiency { get; set; }

        /// <summary>
        /// 挂号日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 排班状态，枚举值 1： 有号 2：已约满 3：停诊
        /// </summary>
        [XmlElement("schedule_status")]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 星期序号
        /// </summary>
        [XmlElement("week_num")]
        public string WeekNum { get; set; }
    }
}
