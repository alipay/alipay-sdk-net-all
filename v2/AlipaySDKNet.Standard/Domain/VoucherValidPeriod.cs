using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherValidPeriod Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherValidPeriod : AopObject
    {
        /// <summary>
        /// 券有效期。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券可使用的开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券生效后N天内可以使用。可以配合wait_days_after_receive字段使用。
        /// </summary>
        [XmlElement("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 券可使用的结束时间。格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 用户领券后需要等待N天，券才可以生效。如果该字段填入0或者不填写，则用户领券后立刻生效。
        /// </summary>
        [XmlElement("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
