using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveCommentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveCommentDeleteModel : AopObject
    {
        /// <summary>
        /// tab3评论id
        /// </summary>
        [XmlElement("alipay_comment_id")]
        public string AlipayCommentId { get; set; }

        /// <summary>
        /// 外部直播间id
        /// </summary>
        [XmlElement("out_live_id")]
        public string OutLiveId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
