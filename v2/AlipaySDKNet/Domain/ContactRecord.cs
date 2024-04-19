using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactRecord Data Structure.
    /// </summary>
    [Serializable]
    public class ContactRecord : AopObject
    {
        /// <summary>
        /// 通话时长(未接通时为0)，单位秒
        /// </summary>
        [XmlElement("call_duration")]
        public string CallDuration { get; set; }

        /// <summary>
        /// 通话发起时间
        /// </summary>
        [XmlElement("call_time")]
        public string CallTime { get; set; }

        /// <summary>
        /// 被呼叫人电话（骑手号码脱敏)
        /// </summary>
        [XmlElement("callee_mobile")]
        public string CalleeMobile { get; set; }

        /// <summary>
        /// 呼叫人电话（骑手号码脱敏）
        /// </summary>
        [XmlElement("caller_mobile")]
        public string CallerMobile { get; set; }

        /// <summary>
        /// 通话接通时间
        /// </summary>
        [XmlElement("pick_up_time")]
        public string PickUpTime { get; set; }

        /// <summary>
        /// 呼叫状态(呼叫状态 1-主叫挂机，2-被叫挂机，4-被叫无应答， 5-被叫忙 ，6-被叫号码停机或空号，7-被叫号码关机，8-运营商服务异常，9-Other，12-未知异常)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
