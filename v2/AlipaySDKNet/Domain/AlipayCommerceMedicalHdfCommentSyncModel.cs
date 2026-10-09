using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfCommentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfCommentSyncModel : AopObject
    {
        /// <summary>
        /// tab3侧的直播间id（加密后）
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 评论来源：tab3｜hdf 如果是ai智能体，用户在哪一端发的消息认为是哪个source
        /// </summary>
        [XmlElement("comment_source")]
        public string CommentSource { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [XmlElement("comment_text")]
        public string CommentText { get; set; }

        /// <summary>
        /// 评论人的昵称
        /// </summary>
        [XmlElement("commenter_name")]
        public string CommenterName { get; set; }

        /// <summary>
        /// 评论人身份 anchor：主播 aiAgent：AI智能体 audience：普通观众 assistant：主播助理
        /// </summary>
        [XmlElement("commenter_role")]
        public string CommenterRole { get; set; }

        /// <summary>
        /// 外部评论ID(好大夫侧的评论ID)
        /// </summary>
        [XmlElement("out_comment_id")]
        public string OutCommentId { get; set; }

        /// <summary>
        /// 外部直播间ID (比如好大夫侧的直播ID)
        /// </summary>
        [XmlElement("out_live_id")]
        public string OutLiveId { get; set; }

        /// <summary>
        /// 外部用户唯一标识(比如好大夫侧的用户加密后ID)
        /// </summary>
        [XmlElement("out_user_encode_id")]
        public string OutUserEncodeId { get; set; }
    }
}
