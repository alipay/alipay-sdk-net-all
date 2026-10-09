using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAssistantPresetquestionConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAssistantPresetquestionConsultModel : AopObject
    {
        /// <summary>
        /// 询问时间
        /// </summary>
        [XmlElement("ask_time")]
        public string AskTime { get; set; }

        /// <summary>
        /// 客户的名称标识，用来标识本次对话的客户身份，必须传，进而在历史会话查询是可以通过用户身份查询对应的历史会话
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [XmlElement("question_content")]
        public string QuestionContent { get; set; }

        /// <summary>
        /// 问题的唯一标识，用于请求本次问题预设置的引导回答的内容
        /// </summary>
        [XmlElement("question_id")]
        public string QuestionId { get; set; }

        /// <summary>
        /// 定义助手的业务场景
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 会话唯一标识，用来表是否是同一个会话，用户传递时使用用户的标识，没有传递时系统自动生成会话id进行标识
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用于标识请求方的来源id，由接口提供方的请求方进行约定
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
