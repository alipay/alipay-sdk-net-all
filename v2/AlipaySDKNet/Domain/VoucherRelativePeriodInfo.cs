using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherRelativePeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherRelativePeriodInfo : AopObject
    {
        /// <summary>
        /// 核销时间限制
        /// </summary>
        [XmlElement("time_restrict_info")]
        public TimeRestrictInfo TimeRestrictInfo { get; set; }

        /// <summary>
        /// 券生效后 N 天内可以使用。 可以配合wait_days_after_receive 字段使用。
        /// </summary>
        [XmlElement("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 用户领券后需要等待 N 天，券才可以生效。  字段值为 0 表示用户领券后立刻生效。
        /// </summary>
        [XmlElement("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
