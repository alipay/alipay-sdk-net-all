using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMiniTemplatemessageBatchsendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMiniTemplatemessageBatchsendModel : AopObject
    {
        /// <summary>
        /// 棋盘人群编码。参数非必传。若传入棋盘人群编码，平台将会对棋盘人群包内的用户和消息模板订阅人群取交集，进行定向消息投送；若不传则默认对该消息模板的订阅人群进行批量发送。 获取棋盘人群编码可参考<a href="https://opendocs.alipay.com/b/05pafz?pathHash=391f9fa7" target="_blank">棋盘密云接入文档</a>
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 模板消息内容，商家/开发者将模板占位符替换为自定义内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 需传入商家小程序内的具体页面路径。用户点击消息卡片时，将会跳转至到指定商家小程序对应页面。
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 定时发送时间，若不传定时发送时间则立即触发批量发送。
        /// </summary>
        [XmlElement("schedule_send_time")]
        public string ScheduleSendTime { get; set; }

        /// <summary>
        /// 商家在商家自运营中心选用的消息模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
