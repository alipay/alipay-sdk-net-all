using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveCommentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveCommentSyncModel : AopObject
    {
        /// <summary>
        /// tab侧的直播间id（加密后）
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 评论发送给目标用户的ID，课代表角色发的评论这里指加密后的支付宝用户2088
        /// </summary>
        [XmlElement("alipay_target_id")]
        public string AlipayTargetId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [XmlElement("comment_text")]
        public string CommentText { get; set; }

        /// <summary>
        /// 评论人昵称
        /// </summary>
        [XmlElement("commenter_name")]
        public string CommenterName { get; set; }

        /// <summary>
        /// 评论人身份
        /// </summary>
        [XmlElement("commenter_role")]
        public string CommenterRole { get; set; }

        /// <summary>
        /// 外部评论id
        /// </summary>
        [XmlElement("out_comment_id")]
        public string OutCommentId { get; set; }

        /// <summary>
        /// 外部直播间ID，比如好大夫侧的直播ID
        /// </summary>
        [XmlElement("out_live_id")]
        public string OutLiveId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_identity")]
        public string OutUserIdentity { get; set; }

        /// <summary>
        /// 评论来源
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 去问医生小尾巴跳转链接
        /// </summary>
        [XmlElement("tail_link_url")]
        public string TailLinkUrl { get; set; }

        /// <summary>
        /// 评论可见范围，ALL：所有人可见【默认】，ONLY_ONESELF
        /// </summary>
        [XmlElement("visible_scope")]
        public string VisibleScope { get; set; }
    }
}
