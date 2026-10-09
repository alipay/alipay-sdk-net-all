using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiMatterCommentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiMatterCommentDTO : AopObject
    {
        /// <summary>
        /// 评论附件
        /// </summary>
        [XmlArray("attachment_list")]
        [XmlArrayItem("open_api_matter_attachment_d_t_o")]
        public List<OpenApiMatterAttachmentDTO> AttachmentList { get; set; }

        /// <summary>
        /// 评论编码
        /// </summary>
        [XmlElement("comment_code")]
        public string CommentCode { get; set; }

        /// <summary>
        /// 发布的内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 事项编码
        /// </summary>
        [XmlElement("matter_code")]
        public string MatterCode { get; set; }

        /// <summary>
        /// 发布人工号
        /// </summary>
        [XmlElement("publisher_id")]
        public string PublisherId { get; set; }

        /// <summary>
        /// 发布人花名
        /// </summary>
        [XmlElement("publisher_name")]
        public string PublisherName { get; set; }

        /// <summary>
        /// 回复的评论编码
        /// </summary>
        [XmlElement("replied_comment_code")]
        public string RepliedCommentCode { get; set; }

        /// <summary>
        /// 回复的内容
        /// </summary>
        [XmlElement("replied_content")]
        public string RepliedContent { get; set; }
    }
}
