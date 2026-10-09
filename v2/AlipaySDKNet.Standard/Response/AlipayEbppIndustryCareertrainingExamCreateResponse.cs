using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingExamCreateResponse : AopResponse
    {
        /// <summary>
        /// 考试ID
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }
    }
}
