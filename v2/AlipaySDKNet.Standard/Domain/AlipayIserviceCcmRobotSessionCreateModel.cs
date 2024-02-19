using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotSessionCreateModel : AopObject
    {
        /// <summary>
        /// 会话扩展信息，如省市区等
        /// </summary>
        [XmlElement("biz_info")]
        public BizInfo BizInfo { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [XmlElement("robot_code")]
        public string RobotCode { get; set; }

        /// <summary>
        /// 聊天窗场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 大模型问答时是否以消息流的方式推送
        /// </summary>
        [XmlElement("stream_output")]
        public bool StreamOutput { get; set; }

        /// <summary>
        /// 访客ID，由调用方提供，比如：微信用户id等
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// ip
        /// </summary>
        [XmlElement("visitor_ip")]
        public string VisitorIp { get; set; }
    }
}
