using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NRiskOrderRecord Data Structure.
    /// </summary>
    [Serializable]
    public class NRiskOrderRecord : AopObject
    {
        /// <summary>
        /// 描叙事件的唯一编号
        /// </summary>
        [XmlElement("event_no")]
        public string EventNo { get; set; }

        /// <summary>
        /// 处理人ID
        /// </summary>
        [XmlElement("handler_id")]
        public string HandlerId { get; set; }

        /// <summary>
        /// 记录处理人姓名
        /// </summary>
        [XmlElement("handler_name")]
        public string HandlerName { get; set; }

        /// <summary>
        /// 补充工单处理说明
        /// </summary>
        [XmlElement("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// 描叙工单的唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 设备工单处理图片
        /// </summary>
        [XmlElement("process_photos")]
        public string ProcessPhotos { get; set; }

        /// <summary>
        /// 用于记录处理的时间
        /// </summary>
        [XmlElement("process_time")]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 工单处置方案记录
        /// </summary>
        [XmlElement("solution_name")]
        public string SolutionName { get; set; }
    }
}
