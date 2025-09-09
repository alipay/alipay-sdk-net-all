using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayDeviceNRiskorderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayDeviceNRiskorderModifyModel : AopObject
    {
        /// <summary>
        /// 预计完成处理天数
        /// </summary>
        [XmlElement("completion_days")]
        public long CompletionDays { get; set; }

        /// <summary>
        /// 处理人ID
        /// </summary>
        [XmlElement("handler_id")]
        public string HandlerId { get; set; }

        /// <summary>
        /// 处理人姓名
        /// </summary>
        [XmlElement("handler_name")]
        public string HandlerName { get; set; }

        /// <summary>
        /// 处理意见备注
        /// </summary>
        [XmlElement("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// 工单ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部工单记录，预留
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [XmlElement("process_time")]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 工单处置方案记录
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
