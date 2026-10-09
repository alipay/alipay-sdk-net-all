using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatSessionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatSessionCreateModel : AopObject
    {
        /// <summary>
        /// 智能体自定义数据
        /// </summary>
        [XmlElement("agent_custom_content")]
        public string AgentCustomContent { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 配置信息查询
        /// </summary>
        [XmlElement("query_config")]
        public QueryAIChatSessionConfigRequest QueryConfig { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 会话id，create_type=create（重新唤起）、clear（清空并新建）时必填
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 智能体归属人id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
