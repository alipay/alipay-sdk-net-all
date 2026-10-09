using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamSyncModel : AopObject
    {
        /// <summary>
        /// 评价ID, 以此作为主键更新
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }

        /// <summary>
        /// 枚举:  DELISTING("已下架") AVAILABLE("已上架")
        /// </summary>
        [XmlElement("exam_status")]
        public string ExamStatus { get; set; }
    }
}
