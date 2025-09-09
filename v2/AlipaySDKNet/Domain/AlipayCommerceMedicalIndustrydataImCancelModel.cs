using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataImCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataImCancelModel : AopObject
    {
        /// <summary>
        /// 内部im会话sessionId
        /// </summary>
        [XmlElement("alipay_chat_id")]
        public string AlipayChatId { get; set; }

        /// <summary>
        /// 支付宝im消息id
        /// </summary>
        [XmlElement("alipay_msg_id")]
        public string AlipayMsgId { get; set; }

        /// <summary>
        /// 问诊订单回流接口出参的order_id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// out_biz_no，唯一，外部商户自有问诊订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部im会话sessionId
        /// </summary>
        [XmlElement("out_chat_id")]
        public string OutChatId { get; set; }

        /// <summary>
        /// 外部对话id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 撤销原因
        /// </summary>
        [XmlElement("recall_reason")]
        public string RecallReason { get; set; }
    }
}
