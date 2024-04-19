using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideChatInitDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideChatInitDTO : AopObject
    {
        /// <summary>
        /// 对话内容
        /// </summary>
        [XmlElement("content")]
        public MedicalGuideContentDTO Content { get; set; }

        /// <summary>
        /// 历史对话记录
        /// </summary>
        [XmlArray("dialog_history")]
        [XmlArrayItem("medical_guide_dialog_d_t_o")]
        public List<MedicalGuideDialogDTO> DialogHistory { get; set; }

        /// <summary>
        /// 机器人logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 机器人昵称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
