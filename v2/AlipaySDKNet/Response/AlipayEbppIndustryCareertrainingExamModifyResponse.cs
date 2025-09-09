using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamModifyResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingExamModifyResponse : AopResponse
    {
        /// <summary>
        /// 评价ID
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }
    }
}
