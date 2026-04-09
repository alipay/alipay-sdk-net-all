using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorMessageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHomedoctorMessageCreateModel : AopObject
    {
        /// <summary>
        /// 消息发送批次
        /// </summary>
        [XmlElement("message_batch_no")]
        public string MessageBatchNo { get; set; }

        /// <summary>
        /// [{"name":"宣教","value":"EDUCATION"},{"name":"体检通知","value":"HEALTH_CHECK"},{"name":"女性早筛","value":"FEMALE_EARLY_SCREENING"},{"name":"孕产妇通知","value":"PREGNANT_CARE"},{"name":"新生儿检查","value":"NEWBORN_CHECK"},{"name":"问卷","value":"QUESTIONNAIRE"}]
        /// </summary>
        [XmlElement("message_biz_type")]
        public string MessageBizType { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 消息链接概要文本
        /// </summary>
        [XmlElement("message_content_digest")]
        public string MessageContentDigest { get; set; }

        /// <summary>
        /// 消息链接缩略图素材链接
        /// </summary>
        [XmlElement("message_content_icon")]
        public string MessageContentIcon { get; set; }

        /// <summary>
        /// 消息独立图片的链接
        /// </summary>
        [XmlElement("message_content_picture")]
        public string MessageContentPicture { get; set; }

        /// <summary>
        /// 消息跳转链接
        /// </summary>
        [XmlElement("message_content_url")]
        public string MessageContentUrl { get; set; }

        /// <summary>
        /// 发送主体
        /// </summary>
        [XmlElement("message_sender")]
        public string MessageSender { get; set; }

        /// <summary>
        /// [{"name":"纯文本","value":"TXT"},{"name":"链接","value":"URL"},{"name":"独立图片","value":"PICTURE"}]
        /// </summary>
        [XmlElement("message_template_type")]
        public string MessageTemplateType { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        [XmlElement("open_id_text")]
        public string OpenIdText { get; set; }
    }
}
