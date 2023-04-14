using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherValidPeriodModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherValidPeriodModify : AopObject
    {
        /// <summary>
        /// 券可使用的开始时间。格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券生效后 N 天内可以使用。
        /// </summary>
        [XmlElement("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 券可使用的结束时间。格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 用户领券后需要等待 N 天，券才可以生效。
        /// </summary>
        [XmlElement("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
