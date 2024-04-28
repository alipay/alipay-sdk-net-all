using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Complaint Data Structure.
    /// </summary>
    [Serializable]
    public class Complaint : AopObject
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 投诉ID
        /// </summary>
        [XmlElement("complaint_id")]
        public string ComplaintId { get; set; }

        /// <summary>
        /// complaint_name
        /// </summary>
        [XmlElement("complaint_name")]
        public string ComplaintName { get; set; }

        /// <summary>
        /// complaint_phone
        /// </summary>
        [XmlElement("complaint_phone")]
        public string ComplaintPhone { get; set; }

        /// <summary>
        /// 投诉状态
        /// </summary>
        [XmlElement("complaint_status")]
        public string ComplaintStatus { get; set; }

        /// <summary>
        /// 投诉类型
        /// </summary>
        [XmlElement("complaint_type")]
        public string ComplaintType { get; set; }

        /// <summary>
        /// 投诉内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 投诉图片
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }

        /// <summary>
        /// 服务商处理链接
        /// </summary>
        [XmlElement("isv_reply_url")]
        public string IsvReplyUrl { get; set; }

        /// <summary>
        /// 商户处理链接
        /// </summary>
        [XmlElement("merchant_reply_url")]
        public string MerchantReplyUrl { get; set; }

        /// <summary>
        /// 商家对于投诉的回复内容
        /// </summary>
        [XmlElement("reply_content")]
        public string ReplyContent { get; set; }
    }
}
