using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainGovernmentSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainGovernmentSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 反馈类目ID
        /// </summary>
        [XmlElement("feedback_code")]
        public string FeedbackCode { get; set; }

        /// <summary>
        /// 反馈内容，字数不超过200个字
        /// </summary>
        [XmlElement("feedback_content")]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// 处理投诉时反馈凭证的图片id，多个逗号隔开（图片id可以通过"商户上传处理图片"接口获取）
        /// </summary>
        [XmlElement("feedback_images")]
        public string FeedbackImages { get; set; }

        /// <summary>
        /// 处理投诉人，字数不超过6个字
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
