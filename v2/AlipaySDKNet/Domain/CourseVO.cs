using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CourseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CourseVO : AopObject
    {
        /// <summary>
        /// 行业审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 支付宝商品类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

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
        /// 是否认证课程，默认true
        /// </summary>
        [XmlElement("certification_course")]
        public bool CertificationCourse { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 课程封面视频 生活号视频id,非URL。
        /// </summary>
        [XmlElement("course_cover_video")]
        public string CourseCoverVideo { get; set; }

        /// <summary>
        /// yyyy-MM-dd  格式时间
        /// </summary>
        [XmlElement("course_end_date")]
        public string CourseEndDate { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 单位为分，399元需填写的值为39900。courseMaxPrice和courseMinPrice都填写时, min<=max
        /// </summary>
        [XmlElement("course_max_price")]
        public long CourseMaxPrice { get; set; }

        /// <summary>
        /// 单位为分，399元需填写的值为39900
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
        /// DELISTING("已下架") FREEZE("已冻结") AVAILABLE("可售卖") AUDITING("审核中") AUDIT_REJECT("审核驳回")
        /// </summary>
        [XmlElement("course_status")]
        public string CourseStatus { get; set; }

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
        /// 是否试听，默认false
        /// </summary>
        [XmlElement("has_trial")]
        public bool HasTrial { get; set; }

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
        /// 课程提交机构编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部课程ID
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
