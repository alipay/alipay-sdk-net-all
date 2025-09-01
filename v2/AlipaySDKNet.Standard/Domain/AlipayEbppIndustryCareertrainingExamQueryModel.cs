using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamQueryModel : AopObject
    {
        /// <summary>
        /// 评价ID
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }

        /// <summary>
        /// 外部评价ID
        /// </summary>
        [XmlElement("out_exam_id")]
        public string OutExamId { get; set; }
    }
}
