using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatHistoryAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatHistoryAddModel : AopObject
    {
        /// <summary>
        /// 答案
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 客户唯一标识，表示目前正在使用问答服务的用户的唯一标识，该字段由客户提供。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 用户提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 标识某个bot，该字段由和客户约定产生。
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 会话ID，标识一通包含多轮对话的问答。该字段由客户进行维护。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 原始请求真实的APPID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 提问时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
