using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCourseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCourseCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝商品类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("certificate_code_list")]
        [XmlArrayItem("string")]
        public List<string> CertificateCodeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 课程封面视频 生活号视频id,非URL。获取方式见：<a href="https://adccloud.yuque.com/adccloud/abilitywarehouse/cggokr7us69cxxo8?singleDoc#" target="_blank">Link text</a>
        /// </summary>
        [XmlElement("course_cover_video")]
        public string CourseCoverVideo { get; set; }

        /// <summary>
        /// yyyy-MM-dd  格式时间
        /// </summary>
        [XmlElement("course_end_date")]
        public string CourseEndDate { get; set; }

        /// <summary>
        /// 599元需填写的值为59900 courseMaxPrice和courseMinPrice都填写时, min<=max
        /// </summary>
        [XmlElement("course_max_price")]
        public long CourseMaxPrice { get; set; }

        /// <summary>
        /// 399元需填写的值为39900
        /// </summary>
        [XmlElement("course_min_price")]
        public long CourseMinPrice { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程须知
        /// </summary>
        [XmlElement("course_notes")]
        public string CourseNotes { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("course_selling_points")]
        [XmlArrayItem("string")]
        public List<string> CourseSellingPoints { get; set; }

        /// <summary>
        /// yyyy-MM-dd  格式时间
        /// </summary>
        [XmlElement("course_start_date")]
        public string CourseStartDate { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("course_tags")]
        [XmlArrayItem("course_tag_v_o")]
        public List<CourseTagVO> CourseTags { get; set; }

        /// <summary>
        /// 课程描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("details_image_list")]
        [XmlArrayItem("string")]
        public List<string> DetailsImageList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("head_image_list")]
        [XmlArrayItem("string")]
        public List<string> HeadImageList { get; set; }

        /// <summary>
        /// 课程提交机构
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 定义外部课程ID, 与本系统课程关联
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 内部备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 培训服务URL
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 学员要求
        /// </summary>
        [XmlElement("student_requirement")]
        public string StudentRequirement { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("teacher_info")]
        [XmlArrayItem("teacher_v_o")]
        public List<TeacherVO> TeacherInfo { get; set; }
    }
}
