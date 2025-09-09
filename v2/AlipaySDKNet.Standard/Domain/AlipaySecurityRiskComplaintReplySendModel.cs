using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskComplaintReplySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskComplaintReplySendModel : AopObject
    {
        /// <summary>
        /// 本次进行留言回复的投诉id(主表主键)
        /// </summary>
        [XmlElement("complaint_id")]
        public string ComplaintId { get; set; }

        /// <summary>
        /// 商户留言内容。
        /// </summary>
        [XmlElement("reply_content")]
        public string ReplyContent { get; set; }
    }
}
