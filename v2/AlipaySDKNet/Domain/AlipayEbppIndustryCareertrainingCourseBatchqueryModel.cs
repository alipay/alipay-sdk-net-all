using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCourseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCourseBatchqueryModel : AopObject
    {
        /// <summary>
        /// （用于支付宝一方页面的分类筛选）
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// ● 湖南省全省:  430000   ● 浙江省-杭州市:  330100   ● 浙江省-杭州市-余杭区:  330110 
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 导游一月速成班
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 外部课程ID
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 页码 
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数: 最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
