using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentMobileLeads Data Structure.
    /// </summary>
    [Serializable]
    public class RentMobileLeads : AopObject
    {
        /// <summary>
        /// 通话的时间长度
        /// </summary>
        [XmlElement("call_duration")]
        public string CallDuration { get; set; }

        /// <summary>
        /// 通话记录ID
        /// </summary>
        [XmlElement("call_id")]
        public string CallId { get; set; }

        /// <summary>
        /// 供服务商/商家向二房东展示的回拨入口
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 该号码为被叫手机上显示的号码
        /// </summary>
        [XmlElement("caller_number")]
        public string CallerNumber { get; set; }

        /// <summary>
        /// 是否接通
        /// </summary>
        [XmlElement("connected")]
        public string Connected { get; set; }

        /// <summary>
        /// 录音下载URL的有效期是7天。
        /// </summary>
        [XmlElement("record_url")]
        public string RecordUrl { get; set; }
    }
}
