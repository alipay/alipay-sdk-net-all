using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayImgReviewQueryResponse.
    /// </summary>
    public class AlipayPayImgReviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 图片审核状态结果， REVIEWING为审核中，REVIEW_SUCCESS为审核成功，REVIEW_FAIL为审核失败，WAIT_REVIEW
        /// </summary>
        [XmlElement("review_status")]
        public string ReviewStatus { get; set; }
    }
}
