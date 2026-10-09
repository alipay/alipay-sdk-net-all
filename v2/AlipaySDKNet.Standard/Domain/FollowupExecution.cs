using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FollowupExecution Data Structure.
    /// </summary>
    [Serializable]
    public class FollowupExecution : AopObject
    {
        /// <summary>
        /// 本次确认的计费分钟数；处理中返回 null，未接通返回 0。
        /// </summary>
        [XmlElement("billable_minutes")]
        public long BillableMinutes { get; set; }

        /// <summary>
        /// 本次外呼执行结果标识，用于记录通话链路的执行事实，不表示接口调用成功或失败；接口处理异常统一通过平台标准错误码表达，具体取值以平台返回为准。
        /// </summary>
        [XmlElement("call_status")]
        public string CallStatus { get; set; }

        /// <summary>
        /// 实际外呼明细 ID，仅包含英文字母与数字，不超过 64 位。
        /// </summary>
        [XmlElement("execution_no")]
        public string ExecutionNo { get; set; }

        /// <summary>
        /// 本次拨打发起时间，采用 ISO 8601 格式。
        /// </summary>
        [XmlElement("occurred_at")]
        public string OccurredAt { get; set; }

        /// <summary>
        /// 录音下载地址；已接通且媒体就绪时返回短时效签名地址，否则返回 null。地址过期后可重新调用本接口获取。
        /// </summary>
        [XmlElement("record_url")]
        public string RecordUrl { get; set; }

        /// <summary>
        /// 本次通话的结果结构；没有结果时返回空对象。
        /// </summary>
        [XmlElement("result_params")]
        public FollowupExecutionResultParams ResultParams { get; set; }
    }
}
