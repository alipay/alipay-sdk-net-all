using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveCommentSyncResponse.
    /// </summary>
    public class AlipayContentLiveCommentSyncResponse : AopResponse
    {
        /// <summary>
        /// 外部在Tab3侧生成的评论id
        /// </summary>
        [XmlElement("alipay_comment_id")]
        public string AlipayCommentId { get; set; }
    }
}
