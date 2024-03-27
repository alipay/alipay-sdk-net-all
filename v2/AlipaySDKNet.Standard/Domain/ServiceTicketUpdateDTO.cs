using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTicketUpdateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTicketUpdateDTO : AopObject
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }
    }
}
