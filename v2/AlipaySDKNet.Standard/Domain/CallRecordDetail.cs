using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallRecordDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CallRecordDetail : AopObject
    {
        /// <summary>
        /// 通话时长：单位（秒）
        /// </summary>
        [XmlElement("call_duration")]
        public long CallDuration { get; set; }

        /// <summary>
        /// 触达状态编码
        /// </summary>
        [XmlElement("contact_status")]
        public string ContactStatus { get; set; }

        /// <summary>
        /// 意图描述
        /// </summary>
        [XmlElement("intent_description")]
        public string IntentDescription { get; set; }

        /// <summary>
        /// 触达消息类型 短信 TEXT_SMS_REPORT，ROBOT_CALL 语音
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 电话外呼通话时长
        /// </summary>
        [XmlElement("meter_num")]
        public long MeterNum { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [XmlElement("meter_unit")]
        public string MeterUnit { get; set; }

        /// <summary>
        /// 外呼手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
