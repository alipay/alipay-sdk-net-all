using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthCourseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthCourseCreateModel : AopObject
    {
        /// <summary>
        /// 章节列表
        /// </summary>
        [XmlArray("course_chapter_list")]
        [XmlArrayItem("job_worth_course_chapter")]
        public List<JobWorthCourseChapter> CourseChapterList { get; set; }

        /// <summary>
        /// 课程的详细描述文案
        /// </summary>
        [XmlElement("course_desc")]
        public string CourseDesc { get; set; }

        /// <summary>
        /// 课程描述图片file_id，通过素材上传接口获取，为了视觉效果，请保证最多3张图
        /// </summary>
        [XmlArray("course_desc_pic")]
        [XmlArrayItem("string")]
        public List<string> CourseDescPic { get; set; }

        /// <summary>
        /// 该套课程的id，全局唯一
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程主图file_id，通过素材上传接口获取
        /// </summary>
        [XmlElement("course_pic")]
        public string CoursePic { get; set; }

        /// <summary>
        /// 课程标题
        /// </summary>
        [XmlElement("course_title")]
        public string CourseTitle { get; set; }

        /// <summary>
        /// 商家的生活号程序id，商家的课程内容需上传的该生活号内
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 教师列表
        /// </summary>
        [XmlArray("teacher_list")]
        [XmlArrayItem("job_worth_course_teacher")]
        public List<JobWorthCourseTeacher> TeacherList { get; set; }
    }
}
