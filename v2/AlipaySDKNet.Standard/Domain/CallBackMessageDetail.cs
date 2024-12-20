using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallBackMessageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CallBackMessageDetail : AopObject
    {
        /// <summary>
        /// 用户开始接听时间，是一个时间点
        /// </summary>
        [XmlElement("answer_time")]
        public string AnswerTime { get; set; }

        /// <summary>
        /// 批次ID，业务幂等使用
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 呼叫开始时间
        /// </summary>
        [XmlElement("call_begin_time")]
        public string CallBeginTime { get; set; }

        /// <summary>
        /// 呼叫id
        /// </summary>
        [XmlElement("call_id")]
        public string CallId { get; set; }

        /// <summary>
        /// 通话录音地址
        /// </summary>
        [XmlElement("chat_record")]
        public string ChatRecord { get; set; }

        /// <summary>
        /// 语音记录
        /// </summary>
        [XmlElement("chats")]
        public string Chats { get; set; }

        /// <summary>
        /// 挂断时间
        /// </summary>
        [XmlElement("hangup_time")]
        public string HangupTime { get; set; }

        /// <summary>
        /// 导入时间
        /// </summary>
        [XmlElement("import_time")]
        public string ImportTime { get; set; }

        /// <summary>
        /// 个人标签
        /// </summary>
        [XmlElement("individual_tag")]
        public string IndividualTag { get; set; }

        /// <summary>
        /// 意向描述
        /// </summary>
        [XmlElement("intent_description")]
        public string IntentDescription { get; set; }

        /// <summary>
        /// 意向标签
        /// </summary>
        [XmlElement("intent_tag")]
        public string IntentTag { get; set; }

        /// <summary>
        /// 回复关键字
        /// </summary>
        [XmlElement("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// 震铃时长（单位毫秒）
        /// </summary>
        [XmlElement("ring_time")]
        public string RingTime { get; set; }

        /// <summary>
        /// 短信条数
        /// </summary>
        [XmlElement("sms_size")]
        public string SmsSize { get; set; }

        /// <summary>
        /// 通话时长(单位秒)
        /// </summary>
        [XmlElement("speaking_duration")]
        public string SpeakingDuration { get; set; }

        /// <summary>
        /// 通话轮数(单位轮)
        /// </summary>
        [XmlElement("speaking_turns")]
        public string SpeakingTurns { get; set; }

        /// <summary>
        /// 外呼状态编码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_description")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 外呼任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 外呼的话术模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
