using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamauditCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamauditCancelModel : AopObject
    {
        /// <summary>
        /// 考试ID
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }
    }
}
