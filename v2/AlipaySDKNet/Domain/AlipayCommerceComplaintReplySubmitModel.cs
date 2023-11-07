using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceComplaintReplySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceComplaintReplySubmitModel : AopObject
    {
        /// <summary>
        /// 投诉ID
        /// </summary>
        [XmlElement("complaint_id")]
        public string ComplaintId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [XmlElement("reply_content")]
        public string ReplyContent { get; set; }
    }
}
