using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelDoctorscheduleQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelDoctorscheduleQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 医生执业行政科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生黄页链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 医生性别
        /// </summary>
        [XmlElement("doctor_gender")]
        public string DoctorGender { get; set; }

        /// <summary>
        /// 外部平台医生Id
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
        /// 学术名称
        /// </summary>
        [XmlElement("education_title")]
        public string EducationTitle { get; set; }

        /// <summary>
        /// 医院特色科室标签
        /// </summary>
        [XmlArray("hospital_dep_feature_tags")]
        [XmlArrayItem("string")]
        public List<string> HospitalDepFeatureTags { get; set; }

        /// <summary>
        /// 医院级别，枚举值 THIRD_CLASS : 三甲 THREE_LEVEL：三级 SECOND_LEVEL：二级 FIRST_LEVEL：一级 HEALTH_CENTER ： 社区卫生服务中心 OTHER ：其他
        /// </summary>
        [XmlElement("hospital_level")]
        public string HospitalLevel { get; set; }

        /// <summary>
        /// 医生执业医院原始名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院排班列表
        /// </summary>
        [XmlArray("hospital_register_info_list")]
        [XmlArrayItem("doctor_hospital_schedule_info_d_t_o")]
        public List<DoctorHospitalScheduleInfoDTO> HospitalRegisterInfoList { get; set; }

        /// <summary>
        /// 灵知医院主院id
        /// </summary>
        [XmlElement("hospital_uinq_code")]
        public string HospitalUinqCode { get; set; }

        /// <summary>
        /// 分页key
        /// </summary>
        [XmlElement("page_key")]
        public string PageKey { get; set; }

        /// <summary>
        /// 外部平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 医生挂号主页链接 包含：医院院区、医生id
        /// </summary>
        [XmlElement("register_page_url")]
        public string RegisterPageUrl { get; set; }

        /// <summary>
        /// 若无排班时，则该字段返回描述内容
        /// </summary>
        [XmlElement("schedule_desc")]
        public string ScheduleDesc { get; set; }

        /// <summary>
        /// 二级缓存页
        /// </summary>
        [XmlElement("second_page_key")]
        public string SecondPageKey { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [XmlArray("service_info_list")]
        [XmlArrayItem("inquiry_service_info")]
        public List<InquiryServiceInfo> ServiceInfoList { get; set; }

        /// <summary>
        /// 医生职称，枚举值： CHIEF_PHYSICIANS ： 主任医师 DEPUTY_CHIEF_PHYSICIANS ：副主任医师 ATTENDING_PHYSICIANS：主治医师 PHYSICIANS ：医师
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
