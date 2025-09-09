using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCourseInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCourseInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 课程信息列表
        /// </summary>
        [XmlArray("course_list")]
        [XmlArrayItem("edu_course_info")]
        public List<EduCourseInfo> CourseList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
