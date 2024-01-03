using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotSessionConsultModel : AopObject
    {
        /// <summary>
        /// 会话额外信息保存,json格式 app_id：小程序appid信息
        /// </summary>
        [XmlElement("biz_info")]
        public BizInfo BizInfo { get; set; }

        /// <summary>
        /// 文档列表
        /// </summary>
        [XmlElement("document_ids")]
        public string DocumentIds { get; set; }

        /// <summary>
        /// 知识点id
        /// </summary>
        [XmlElement("knowledge_id")]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [XmlElement("robot_code")]
        public string RobotCode { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 访客ID，由调用方提供，比如：微信用户id等
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
