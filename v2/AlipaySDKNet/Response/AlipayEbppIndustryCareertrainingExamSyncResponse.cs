using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingExamSyncResponse : AopResponse
    {
        /// <summary>
        /// 评价ID
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }
    }
}
