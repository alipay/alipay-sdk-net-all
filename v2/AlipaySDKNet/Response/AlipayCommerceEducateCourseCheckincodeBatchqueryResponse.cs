using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCourseCheckincodeBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCourseCheckincodeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 课程签到码列表
        /// </summary>
        [XmlArray("check_in_code_list")]
        [XmlArrayItem("edu_course_check_in_rule")]
        public List<EduCourseCheckInRule> CheckInCodeList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
