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
        /// 针对评价字数、评价图片数据、评价视频时长的质量描述
        /// </summary>
        [XmlElement("comment_desc")]
        public string CommentDesc { get; set; }

        /// <summary>
        /// 高德侧传入的本次评价单号
        /// </summary>
        [XmlElement("comment_no")]
        public string CommentNo { get; set; }

        /// <summary>
        /// 评价来源信息，业务接入分配
        /// </summary>
        [XmlElement("comment_source")]
        public string CommentSource { get; set; }

        /// <summary>
        /// 评价的状态标签值
        /// </summary>
        [XmlElement("comment_tag")]
        public string CommentTag { get; set; }

        /// <summary>
        /// true代表包含真实标签，false标签不包含真实标签
        /// </summary>
        [XmlElement("has_real_label")]
        public bool HasRealLabel { get; set; }

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
