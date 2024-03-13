using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LlmServiceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LlmServiceDTO : AopObject
    {
        /// <summary>
        /// 对话内容列表，流式输出中大模型的每次输出语句块
        /// </summary>
        [XmlArray("answer")]
        [XmlArrayItem("medical_llm_answer_d_t_o")]
        public List<MedicalLlmAnswerDTO> Answer { get; set; }

        /// <summary>
        /// 表示回答内容类型
        /// </summary>
        [XmlElement("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 会话ID，蚂蚁侧生成
        /// </summary>
        [XmlElement("ant_session_id")]
        public string AntSessionId { get; set; }

        /// <summary>
        /// 对话ID，每次提问都会产生一个新的对话ID，蚂蚁侧生成
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 只返回智能导诊意图 医疗科普——MEDICALSCI 用药指南—— DRUGGUIDE 智能导诊—— DEPARTGUIDE——只返回这个
        /// </summary>
        [XmlElement("intention")]
        public string Intention { get; set; }

        /// <summary>
        /// true：已结束 false：未结束，还有内容
        /// </summary>
        [XmlElement("is_finished")]
        public bool IsFinished { get; set; }

        /// <summary>
        /// true：需要撤回 false：无需撤回
        /// </summary>
        [XmlElement("is_with_draw")]
        public bool IsWithDraw { get; set; }

        /// <summary>
        /// 卫健委通用助理——WJWCOMASS
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 目前只有文字模板
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
