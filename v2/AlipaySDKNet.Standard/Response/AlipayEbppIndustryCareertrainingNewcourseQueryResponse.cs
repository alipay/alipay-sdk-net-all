using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingNewcourseQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingNewcourseQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("applicable_population_list")]
        [XmlArrayItem("string")]
        public List<string> ApplicablePopulationList { get; set; }

        /// <summary>
        /// 测评服务-名称
        /// </summary>
        [XmlElement("as_custom_name")]
        public string AsCustomName { get; set; }

        /// <summary>
        /// 测评服务-场次
        /// </summary>
        [XmlElement("as_times")]
        public long AsTimes { get; set; }

        /// <summary>
        /// 行业审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("category_id_list")]
        [XmlArrayItem("number")]
        public List<long> CategoryIdList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("certificate_code_list")]
        [XmlArrayItem("string")]
        public List<string> CertificateCodeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("certificate_desc_list")]
        [XmlArrayItem("string")]
        public List<string> CertificateDescList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 咨询钩子
        /// </summary>
        [XmlElement("consultation_hook")]
        public string ConsultationHook { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("container_type_list")]
        [XmlArrayItem("string")]
        public List<string> ContainerTypeList { get; set; }

        /// <summary>
        /// 课程封面视频,生活号视频id
        /// </summary>
        [XmlElement("course_cover_video")]
        public string CourseCoverVideo { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程介绍
        /// </summary>
        [XmlElement("course_introduction")]
        public string CourseIntroduction { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程状态
        /// </summary>
        [XmlElement("course_status")]
        public string CourseStatus { get; set; }

        /// <summary>
        /// 课程类型
        /// </summary>
        [XmlElement("course_type")]
        public string CourseType { get; set; }

        /// <summary>
        /// 封面图片
        /// </summary>
        [XmlElement("cover_image")]
        public string CoverImage { get; set; }

        /// <summary>
        /// 课程描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 折扣方式
        /// </summary>
        [XmlElement("discount_method")]
        public string DiscountMethod { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("head_image_list")]
        [XmlArrayItem("string")]
        public List<string> HeadImageList { get; set; }

        /// <summary>
        /// 行业展示状态
        /// </summary>
        [XmlElement("industry_show_status")]
        public string IndustryShowStatus { get; set; }

        /// <summary>
        /// 学习资料-描述
        /// </summary>
        [XmlElement("lm_description")]
        public string LmDescription { get; set; }

        /// <summary>
        /// 在线直播课-场次
        /// </summary>
        [XmlElement("lsc_sessions")]
        public long LscSessions { get; set; }

        /// <summary>
        /// 原价（分）
        /// </summary>
        [XmlElement("market_price")]
        public long MarketPrice { get; set; }

        /// <summary>
        /// 线下课-课时,小时
        /// </summary>
        [XmlElement("oc_hours")]
        public long OcHours { get; set; }

        /// <summary>
        /// 线下课-每班人数
        /// </summary>
        [XmlElement("oc_students_per_class")]
        public long OcStudentsPerClass { get; set; }

        /// <summary>
        /// 来源平台编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部课程ID
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 实训课-课时,小时
        /// </summary>
        [XmlElement("pt_hours")]
        public long PtHours { get; set; }

        /// <summary>
        /// 实训课-是否提供场地与设备
        /// </summary>
        [XmlElement("pt_provide_venue_and_equipment")]
        public bool PtProvideVenueAndEquipment { get; set; }

        /// <summary>
        /// 关联程度
        /// </summary>
        [XmlElement("relation_degree")]
        public string RelationDegree { get; set; }

        /// <summary>
        /// 内部备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 报价（分）
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 课程介绍 - 是否启用课程大纲
        /// </summary>
        [XmlElement("separate_syllabus")]
        public bool SeparateSyllabus { get; set; }

        /// <summary>
        /// 课程介绍 - 是否启用课程大纲结构化
        /// </summary>
        [XmlElement("separate_syllabus_structured")]
        public bool SeparateSyllabusStructured { get; set; }

        /// <summary>
        /// 小程序课程详情页URL
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 课程大纲
        /// </summary>
        [XmlElement("syllabus_rich_text")]
        public string SyllabusRichText { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("syllabus_structured")]
        [XmlArrayItem("syllabus_structured_query_v_o")]
        public List<SyllabusStructuredQueryVO> SyllabusStructured { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("teacher_info")]
        [XmlArrayItem("teacher_v_o")]
        public List<TeacherVO> TeacherInfo { get; set; }

        /// <summary>
        /// 视频课-时
        /// </summary>
        [XmlElement("vc_hours")]
        public long VcHours { get; set; }

        /// <summary>
        /// 视频课-分
        /// </summary>
        [XmlElement("vc_minutes")]
        public long VcMinutes { get; set; }

        /// <summary>
        /// 视频课-有效期单位，月或年
        /// </summary>
        [XmlElement("vc_validity_unit")]
        public string VcValidityUnit { get; set; }

        /// <summary>
        /// 视频课-有效期，月或年，填0表示无限
        /// </summary>
        [XmlElement("vc_validity_value")]
        public long VcValidityValue { get; set; }
    }
}
