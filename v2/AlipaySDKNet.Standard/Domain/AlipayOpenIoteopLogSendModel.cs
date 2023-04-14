using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIoteopLogSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIoteopLogSendModel : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 支持秒s，毫秒ms，微秒ms,  纳秒ns，10.1ms，小数点后不能超过3位
        /// </summary>
        [XmlElement("cost_time")]
        public string CostTime { get; set; }

        /// <summary>
        /// 指标列表
        /// </summary>
        [XmlArray("index_list")]
        [XmlArrayItem("iot_emergency_log_index_save_open_mq_request")]
        public List<IotEmergencyLogIndexSaveOpenMqRequest> IndexList { get; set; }

        /// <summary>
        /// 序列图id
        /// </summary>
        [XmlElement("sequence_diagram_id")]
        public string SequenceDiagramId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 链路id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
