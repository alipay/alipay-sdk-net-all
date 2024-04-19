using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MsgOrderExtInfo : AopObject
    {
        /// <summary>
        /// 办事大厅地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 办事具体附加信息
        /// </summary>
        [XmlElement("attachment_info")]
        public string AttachmentInfo { get; set; }

        /// <summary>
        /// 如果是直接取号，则赋予取号时间。【格式要求：yyyy-MM-dd HH:mm:ss】
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 调用小程序appId
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 办事大厅名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 取号的号码【数字值】
        /// </summary>
        [XmlElement("queue_number")]
        public string QueueNumber { get; set; }

        /// <summary>
        /// 预约变更理由【发生变更后，后续状态都要传】
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 预约时间段的开始时间点，如果是直接取号，则赋予取号时间。【格式要求：yyyy-MM-dd HH:mm:ss】
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 线下取号的时间点【格式要求：yyyy-MM-dd HH:mm:ss】
        /// </summary>
        [XmlElement("take_time")]
        public string TakeTime { get; set; }

        /// <summary>
        /// 在不同状态下可以显示相应温馨提示信息。 同时提供评价服务链接，服务链接字段为“target_url”
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 当前排队的人数【到号及办事完成等后续状态则传 0 】.
        /// </summary>
        [XmlElement("wait_number")]
        public string WaitNumber { get; set; }

        /// <summary>
        /// 办事窗口
        /// </summary>
        [XmlElement("window")]
        public string Window { get; set; }
    }
}
