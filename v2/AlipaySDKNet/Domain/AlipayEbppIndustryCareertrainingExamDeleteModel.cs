using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamDeleteModel : AopObject
    {
        /// <summary>
        /// 评价id，与out_exam_id至少传一个
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }

        /// <summary>
        /// 外部评价id，与exam_id至少传一个
        /// </summary>
        [XmlElement("out_exam_id")]
        public string OutExamId { get; set; }
    }
}
