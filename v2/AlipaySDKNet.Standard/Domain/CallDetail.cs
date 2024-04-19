using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CallDetail : AopObject
    {
        /// <summary>
        /// 附加中间号码，双呼场景下可能用到
        /// </summary>
        [XmlElement("additional_broker")]
        public string AdditionalBroker { get; set; }

        /// <summary>
        /// 坐席ID列表，多个值用逗号分隔
        /// </summary>
        [XmlElement("agent_ids")]
        public string AgentIds { get; set; }

        /// <summary>
        /// 通话涉及到的坐席名称列表，多个坐席之间使用英文逗号隔开。
        /// </summary>
        [XmlElement("agent_names")]
        public string AgentNames { get; set; }

        /// <summary>
        /// 中间号码
        /// </summary>
        [XmlElement("broker")]
        public string Broker { get; set; }

        /// <summary>
        /// 通话时长，呼入从通话进入IVR开始计时，呼出从接通开始计时，单位秒。
        /// </summary>
        [XmlElement("call_duration")]
        public long CallDuration { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("called_number")]
        public string CalledNumber { get; set; }

        /// <summary>
        /// 被叫归属地
        /// </summary>
        [XmlElement("callee_location")]
        public string CalleeLocation { get; set; }

        /// <summary>
        /// 主叫归属地
        /// </summary>
        [XmlElement("caller_location")]
        public string CallerLocation { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [XmlElement("calling_number")]
        public string CallingNumber { get; set; }

        /// <summary>
        /// 通话结束原因。 枚举值： ● AbandonedInQueue：排队放弃。 ● NoAnswer：客户未接。 ● QueuingTimeout：排队超时。 ● Voicemail：转语音邮箱。 ● QueuingFailed：转人工失败。 ● QueuingOverflow：排队溢出。 ● AbandonedInVoiceNavigator：智能导航中放弃。 ● Success：正常结束。 ● IVRException：IVR异常。 ● AbandonedInRing：振铃放弃。 ● AbandonedInIVR：IVR放弃。 ● Reject：客户拒接。 ● ForwardToOutsideNumber：转外线。
        /// </summary>
        [XmlElement("contact_disposition")]
        public string ContactDisposition { get; set; }

        /// <summary>
        /// 热线渠道通话id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 通话类型 枚举值： ● Outbound：呼出。 ● Back2Back：双呼。 ● PrivacyDial：加密通话。 ● Internal：内部呼叫。 ● Predictive：预测式外呼。 ● Inbound：呼入。 ● Conference：会议。
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 未接通原因。 枚举值： ● NoAnswer：无人接听。 ● OutOfService：停机。 ● NotExist：空号。 ● Restricted：呼叫受限。 ● Busy：占线。 ● NotConnected：无法接通。 ● PowerOff：关机。
        /// </summary>
        [XmlElement("early_media_state")]
        public string EarlyMediaState { get; set; }

        /// <summary>
        /// 通话建立的时间，如果通话没有建立，此值为空，格式为Unix时间戳，单位毫秒。
        /// </summary>
        [XmlElement("established_time")]
        public long EstablishedTime { get; set; }

        /// <summary>
        /// 热线渠道服务实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// IVR时长，即从开始进入IVR到开始进入转人工队列（或客户放弃）之间的时长，单位秒。
        /// </summary>
        [XmlElement("ivr_time")]
        public long IvrTime { get; set; }

        /// <summary>
        /// 排队时长，即从开始进入转人工队列到坐席开始振铃（或客户放弃，队列超时，队列溢出）之间的时长，单位秒。
        /// </summary>
        [XmlElement("queue_time")]
        public long QueueTime { get; set; }

        /// <summary>
        /// 录音时长，单位秒。
        /// </summary>
        [XmlElement("recording_duration")]
        public long RecordingDuration { get; set; }

        /// <summary>
        /// 录音是否已经生成，若通话没有建立，则返回false。
        /// </summary>
        [XmlElement("recording_ready")]
        public bool RecordingReady { get; set; }

        /// <summary>
        /// 挂断方。 枚举值： ● agent：坐席。 ● customer：客户
        /// </summary>
        [XmlElement("release_initiator")]
        public string ReleaseInitiator { get; set; }

        /// <summary>
        /// 务通道的挂断原因，表示当前话务通道为什么会被挂断，取值来自SIP协议中定义的响应码，请客户参考SIP协议分析挂断原因
        /// </summary>
        [XmlElement("release_reason")]
        public string ReleaseReason { get; set; }

        /// <summary>
        /// 通话结束时间，格式为Unix时间戳，单位毫秒。
        /// </summary>
        [XmlElement("release_time")]
        public long ReleaseTime { get; set; }

        /// <summary>
        /// 振铃时长，即从坐席振铃到坐席接起（或客户放弃）之间的时长，单位秒。
        /// </summary>
        [XmlElement("ring_time")]
        public long RingTime { get; set; }

        /// <summary>
        /// 满意度描述，对应于满意度IVR中满意度模块的配置，客户自行定义。
        /// </summary>
        [XmlElement("satisfaction_description")]
        public string SatisfactionDescription { get; set; }

        /// <summary>
        /// 满意度，即满意度按键数字（1位数字）的值。
        /// </summary>
        [XmlElement("satisfaction_index")]
        public long SatisfactionIndex { get; set; }

        /// <summary>
        /// 满意度调查渠道。 枚举值： ● IVR：语音满意度。 ● SMS：短信满意度。
        /// </summary>
        [XmlElement("satisfaction_survey_channel")]
        public string SatisfactionSurveyChannel { get; set; }

        /// <summary>
        /// 是否发起了满意度调查
        /// </summary>
        [XmlElement("satisfaction_survey_offered")]
        public bool SatisfactionSurveyOffered { get; set; }

        /// <summary>
        /// 参与通话的座席所属的技能组ID，多个技能组以逗号分隔。
        /// </summary>
        [XmlElement("skill_group_ids")]
        public string SkillGroupIds { get; set; }

        /// <summary>
        /// 参与通话的座席所属的技能组名称，多个技能组以英文逗号分隔。
        /// </summary>
        [XmlElement("skill_group_names")]
        public string SkillGroupNames { get; set; }

        /// <summary>
        /// 通话开始时间，内呼从进入IVR开始，外呼从拨号开始计算，格式为Unix字符串，单位毫秒。
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 客户等待时长，即QueueTime+RingTime，若客户等待期间放弃，则为0，单位秒。
        /// </summary>
        [XmlElement("wait_time")]
        public long WaitTime { get; set; }
    }
}
