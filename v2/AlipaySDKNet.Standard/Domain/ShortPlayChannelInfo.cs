using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayChannelInfo : AopObject
    {
        /// <summary>
        /// CCID，该渠道的短剧标识
        /// </summary>
        [XmlElement("cc_id")]
        public string CcId { get; set; }

        /// <summary>
        /// 渠道：0 商家小程序；1 生活号；2 官方小程序
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 生活号
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 发起时间，秒级时间戳
        /// </summary>
        [XmlElement("request_time")]
        public long RequestTime { get; set; }

        /// <summary>
        /// 发布任务ID
        /// </summary>
        [XmlElement("review_id")]
        public string ReviewId { get; set; }

        /// <summary>
        /// 发布结果：0 发布成功；1 发布失败；2 审核中；
        /// </summary>
        [XmlElement("review_result")]
        public string ReviewResult { get; set; }

        /// <summary>
        /// 审核建议（版审建议 + 剧安审建议）
        /// </summary>
        [XmlElement("review_suggest")]
        public string ReviewSuggest { get; set; }

        /// <summary>
        /// 状态 0：审核中 1：审核失败 2：已发布 4：平台处置下架 5：用户下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
