using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAssistantGuessquestionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAssistantGuessquestionQueryModel : AopObject
    {
        /// <summary>
        /// 场景类唯一标识符
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 会话唯一标识，用来表是否是同一个会话，用户传递时使用用户的标识，没有传递时系统自动生成会话id进行标识。
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
