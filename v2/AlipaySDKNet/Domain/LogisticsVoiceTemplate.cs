using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsVoiceTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsVoiceTemplate : AopObject
    {
        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 只有ONLINE为可用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 语音内容URL
        /// </summary>
        [XmlElement("voice_content_url")]
        public string VoiceContentUrl { get; set; }

        /// <summary>
        /// 语音模板ID
        /// </summary>
        [XmlElement("voice_template_id")]
        public string VoiceTemplateId { get; set; }

        /// <summary>
        /// 语音模板名称
        /// </summary>
        [XmlElement("voice_template_name")]
        public string VoiceTemplateName { get; set; }

        /// <summary>
        /// 语音文本
        /// </summary>
        [XmlElement("voice_text")]
        public string VoiceText { get; set; }
    }
}
