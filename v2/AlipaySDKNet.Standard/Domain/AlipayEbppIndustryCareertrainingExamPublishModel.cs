using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamPublishModel : AopObject
    {
        /// <summary>
        /// 考试ID
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }

        /// <summary>
        /// 投放状态 LAUNCH 投放 CANCEL_LAUNCH 撤退投放（仅当前商品为非审核中可撤销）
        /// </summary>
        [XmlElement("publish_status")]
        public string PublishStatus { get; set; }
    }
}
