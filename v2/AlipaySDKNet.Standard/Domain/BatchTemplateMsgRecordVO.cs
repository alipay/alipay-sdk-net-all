using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchTemplateMsgRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class BatchTemplateMsgRecordVO : AopObject
    {
        /// <summary>
        /// 批量发送记录ID，唯一标识一次消息模板批量查询
        /// </summary>
        [XmlElement("batch_msg_id")]
        public string BatchMsgId { get; set; }

        /// <summary>
        /// 批量发送指定的棋盘人群编码，用于定向人群消息投送。获取棋盘人群编码可参考<a href="https://opendocs.alipay.com/b/05pafz?pathHash=391f9fa7" target="_blank">棋盘密云接入文档</a>
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 消息卡片内容，包括消息模板标题、消息关键词信息以及消息跳链
        /// </summary>
        [XmlElement("msg_content")]
        public MsgTemplateContentVO MsgContent { get; set; }

        /// <summary>
        /// 消息发送量
        /// </summary>
        [XmlElement("msg_send_count")]
        public long MsgSendCount { get; set; }

        /// <summary>
        /// 批量发送状态
        /// </summary>
        [XmlElement("msg_send_status")]
        public string MsgSendStatus { get; set; }

        /// <summary>
        /// 消息实际发送时间，若商户在调用消息发送接口时指定了定时时间，则该值为商户设定的定时发送时间
        /// </summary>
        [XmlElement("msg_send_time")]
        public string MsgSendTime { get; set; }

        /// <summary>
        /// 商家在商家自运营中心选用的消息模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
