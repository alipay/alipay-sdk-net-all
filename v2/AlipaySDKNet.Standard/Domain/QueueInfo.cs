using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QueueInfo : AopObject
    {
        /// <summary>
        /// 当前叫号
        /// </summary>
        [XmlElement("current_num")]
        public string CurrentNum { get; set; }

        /// <summary>
        /// 就餐人数
        /// </summary>
        [XmlElement("dining_num")]
        public string DiningNum { get; set; }

        /// <summary>
        /// 排队号
        /// </summary>
        [XmlElement("queue_num")]
        public string QueueNum { get; set; }

        /// <summary>
        /// 预计还需多少时间
        /// </summary>
        [XmlElement("still_wait_time")]
        public string StillWaitTime { get; set; }

        /// <summary>
        /// 桌型
        /// </summary>
        [XmlElement("table_type")]
        public string TableType { get; set; }

        /// <summary>
        /// 前面还有多少桌
        /// </summary>
        [XmlElement("wait_num")]
        public string WaitNum { get; set; }

        /// <summary>
        /// 已等待时间
        /// </summary>
        [XmlElement("waiting_time")]
        public string WaitingTime { get; set; }
    }
}
