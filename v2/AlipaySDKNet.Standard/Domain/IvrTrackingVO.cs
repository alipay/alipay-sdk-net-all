using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IvrTrackingVO Data Structure.
    /// </summary>
    [Serializable]
    public class IvrTrackingVO : AopObject
    {
        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [XmlElement("caller")]
        public string Caller { get; set; }

        /// <summary>
        /// 话务通道 ID
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 通话id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 进入该 IVR 节点的时间，格式为 Unix 时间戳，单位毫秒。
        /// </summary>
        [XmlElement("enter_time")]
        public string EnterTime { get; set; }

        /// <summary>
        /// 联系流 ID
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 联系流名称
        /// </summary>
        [XmlElement("flow_name")]
        public string FlowName { get; set; }

        /// <summary>
        /// 离开该 IVR 节点的时间
        /// </summary>
        [XmlElement("leave_time")]
        public string LeaveTime { get; set; }

        /// <summary>
        /// 节点的状态码。
        /// </summary>
        [XmlElement("node_exit_code")]
        public string NodeExitCode { get; set; }

        /// <summary>
        /// 节点 ID
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点的属性（根据不同的属性表示的内容不同）
        /// </summary>
        [XmlElement("node_properties")]
        public string NodeProperties { get; set; }

        /// <summary>
        /// 节点类型。
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 节点变量(根据不同的节点表示的不同意思)
        /// </summary>
        [XmlElement("node_variables")]
        public string NodeVariables { get; set; }
    }
}
