using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentBaseinfoQueryResponse.
    /// </summary>
    public class AlipayOpenAgentBaseinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体应用描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("app_label")]
        [XmlArrayItem("string")]
        public List<string> AppLabel { get; set; }

        /// <summary>
        /// 智能体应用logo
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 智能体应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 选择智能体的发音人
        /// </summary>
        [XmlElement("app_tone")]
        public string AppTone { get; set; }

        /// <summary>
        /// 对话页的背景图片
        /// </summary>
        [XmlElement("background")]
        public string Background { get; set; }

        /// <summary>
        /// 底部输入框指引
        /// </summary>
        [XmlElement("card_bottom")]
        public string CardBottom { get; set; }

        /// <summary>
        /// 进入智能体的开场白
        /// </summary>
        [XmlElement("card_guide")]
        public string CardGuide { get; set; }

        /// <summary>
        /// 选择智能体开场展现的类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 是否开启继续问
        /// </summary>
        [XmlElement("continue_ask")]
        public bool ContinueAsk { get; set; }

        /// <summary>
        /// 自定义卡片配置信息
        /// </summary>
        [XmlElement("custom_card_body")]
        public string CustomCardBody { get; set; }

        /// <summary>
        /// 自定卡片ID
        /// </summary>
        [XmlElement("custom_card_id")]
        public string CustomCardId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_qa_mode")]
        [XmlArrayItem("string")]
        public List<string> SupportQaMode { get; set; }
    }
}
