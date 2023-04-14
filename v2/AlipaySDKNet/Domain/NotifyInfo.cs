using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyInfo : AopObject
    {
        /// <summary>
        /// biz_id+是+返回的业务主体+根据notify_id或者trade_no得到
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// biz_no+是+PID+根据notify_id或者trade_no得到
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// notify_id+是+通知id+mnotify得到
        /// </summary>
        [XmlElement("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// send_result+是+发送结果+根据notify_id或者trade_no得到
        /// </summary>
        [XmlElement("send_result")]
        public string SendResult { get; set; }

        /// <summary>
        /// send_times+是+发送的次数+根据notify_id或者trade_no得到
        /// </summary>
        [XmlElement("send_times")]
        public long SendTimes { get; set; }
    }
}
