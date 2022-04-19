using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantTradecomplainReplySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantTradecomplainReplySubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 回复留言内容
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
