using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerCreditinfoCommentdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCreditinfoCommentdataSyncModel : AopObject
    {
        /// <summary>
        /// 高德侧传入的本次评价单号
        /// </summary>
        [XmlElement("comment_no")]
        public string CommentNo { get; set; }

        /// <summary>
        /// 评价的状态标签值
        /// </summary>
        [XmlElement("comment_tag")]
        public string CommentTag { get; set; }

        /// <summary>
        /// 商户外部单号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 真实性标签
        /// </summary>
        [XmlArray("real_label")]
        [XmlArrayItem("string")]
        public List<string> RealLabel { get; set; }

        /// <summary>
        /// 总分100分制，具体的打分分数
        /// </summary>
        [XmlElement("user_score")]
        public string UserScore { get; set; }
    }
}
