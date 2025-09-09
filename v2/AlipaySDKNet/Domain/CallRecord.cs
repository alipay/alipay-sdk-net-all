using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallRecord Data Structure.
    /// </summary>
    [Serializable]
    public class CallRecord : AopObject
    {
        /// <summary>
        /// 通话ID
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 小二信息
        /// </summary>
        [XmlElement("biz_owner")]
        public string BizOwner { get; set; }

        /// <summary>
        /// 呼叫时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("call_time")]
        public string CallTime { get; set; }

        /// <summary>
        /// 呼叫类型，人机协同呼叫，人工呼叫，智能呼叫，客户呼入
        /// </summary>
        [XmlElement("call_type")]
        public string CallType { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("caller")]
        public string Caller { get; set; }

        /// <summary>
        /// 是否接通，是或否
        /// </summary>
        [XmlElement("connect_status")]
        public string ConnectStatus { get; set; }

        /// <summary>
        /// 线索ID
        /// </summary>
        [XmlElement("cue_id")]
        public long CueId { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 创建时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 挂机方
        /// </summary>
        [XmlElement("hangup_dir")]
        public string HangupDir { get; set; }

        /// <summary>
        /// 挂断原因
        /// </summary>
        [XmlElement("hangup_reason")]
        public string HangupReason { get; set; }

        /// <summary>
        /// 智能时长，单位秒
        /// </summary>
        [XmlElement("ivr_time")]
        public long IvrTime { get; set; }

        /// <summary>
        /// 人工时长，单位秒
        /// </summary>
        [XmlElement("manual_time")]
        public long ManualTime { get; set; }

        /// <summary>
        /// 数字员工
        /// </summary>
        [XmlElement("process")]
        public string Process { get; set; }

        /// <summary>
        /// 等待时长，单位秒
        /// </summary>
        [XmlElement("queue_time")]
        public long QueueTime { get; set; }

        /// <summary>
        /// 通话结束时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("release_time")]
        public string ReleaseTime { get; set; }

        /// <summary>
        /// 响铃时长，单位秒
        /// </summary>
        [XmlElement("ring_time")]
        public long RingTime { get; set; }

        /// <summary>
        /// 通话开始时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 通话时长，单位秒
        /// </summary>
        [XmlElement("talk_time")]
        public long TalkTime { get; set; }
    }
}
