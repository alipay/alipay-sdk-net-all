using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplaintProcessorResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ComplaintProcessorResponse : AopObject
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 投诉ID
        /// </summary>
        [XmlElement("complaint_id")]
        public string ComplaintId { get; set; }

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
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户的pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [XmlElement("reply_content")]
        public string ReplyContent { get; set; }
    }
}
