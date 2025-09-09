using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrescReview Data Structure.
    /// </summary>
    [Serializable]
    public class PrescReview : AopObject
    {
        /// <summary>
        /// 商家审方药师姓名
        /// </summary>
        [XmlElement("pharmacist_name")]
        public string PharmacistName { get; set; }

        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [XmlElement("review_reject_note")]
        public string ReviewRejectNote { get; set; }

        /// <summary>
        /// 审核状态 1-待审核 2-通过 3-驳回 4-超时
        /// </summary>
        [XmlElement("review_status")]
        public string ReviewStatus { get; set; }

        /// <summary>
        /// 药师审核时间
        /// </summary>
        [XmlElement("review_time")]
        public string ReviewTime { get; set; }
    }
}
