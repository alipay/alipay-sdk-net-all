using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcRefundReason Data Structure.
    /// </summary>
    [Serializable]
    public class MpcRefundReason : AopObject
    {
        /// <summary>
        /// 是否要求上传凭证
        /// </summary>
        [XmlElement("proof_required")]
        public bool ProofRequired { get; set; }

        /// <summary>
        /// 理由文本 id
        /// </summary>
        [XmlElement("reason_text_id")]
        public string ReasonTextId { get; set; }

        /// <summary>
        /// 理由文本
        /// </summary>
        [XmlElement("reason_tips")]
        public string ReasonTips { get; set; }

        /// <summary>
        /// 是否要求留言
        /// </summary>
        [XmlElement("refund_desc_required")]
        public bool RefundDescRequired { get; set; }
    }
}
