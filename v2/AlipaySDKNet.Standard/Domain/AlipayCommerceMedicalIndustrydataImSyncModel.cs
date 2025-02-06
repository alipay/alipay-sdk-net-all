using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataImSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataImSyncModel : AopObject
    {
        /// <summary>
        /// 内部im会话chatId
        /// </summary>
        [XmlElement("alipay_chat_id")]
        public string AlipayChatId { get; set; }

        /// <summary>
        /// 问诊订单回流接口出参的order_id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 消息内容：文本-内容、图片-url、语音-url、视频-url、定制卡片
        /// </summary>
        [XmlElement("content")]
        public ContentVo Content { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// out_biz_no，唯一，外部商户自有问诊订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部im会话chatId
        /// </summary>
        [XmlElement("out_chat_id")]
        public string OutChatId { get; set; }

        /// <summary>
        /// 服务提供者:外部医生/医助id
        /// </summary>
        [XmlElement("out_doctor_id")]
        public string OutDoctorId { get; set; }

        /// <summary>
        /// 外部对话id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 服务提供者角色类型
        /// </summary>
        [XmlElement("provider_type")]
        public string ProviderType { get; set; }

        /// <summary>
        /// 服务提供者:医生/医助姓名
        /// </summary>
        [XmlElement("service_provider_name")]
        public string ServiceProviderName { get; set; }
    }
}
