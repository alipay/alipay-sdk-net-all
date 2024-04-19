using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantServiceconsultFeedbackSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantServiceconsultFeedbackSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝侧服务咨询工单号
        /// </summary>
        [XmlElement("consult_event_id")]
        public string ConsultEventId { get; set; }

        /// <summary>
        /// 回复内容，最多不超过200个字
        /// </summary>
        [XmlElement("reply_content")]
        public string ReplyContent { get; set; }

        /// <summary>
        /// 商家处理问题反馈时的回复凭证的图片id，多个逗号隔开（图片id可以通过"商户上传处理图片"接口获取）
        /// </summary>
        [XmlElement("reply_images")]
        public string ReplyImages { get; set; }
    }
}
