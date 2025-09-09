using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallBackActionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CallBackActionDetail : AopObject
    {
        /// <summary>
        /// 发起语音外呼动作程序编码
        /// </summary>
        [XmlElement("action_driver_code")]
        public long ActionDriverCode { get; set; }

        /// <summary>
        /// 外呼回执时间
        /// </summary>
        [XmlElement("call_back_time")]
        public string CallBackTime { get; set; }

        /// <summary>
        /// 外呼回执内容明细信息
        /// </summary>
        [XmlElement("message_detail")]
        public CallBackMessageDetail MessageDetail { get; set; }

        /// <summary>
        /// 外呼回执消息类型
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }
    }
}
