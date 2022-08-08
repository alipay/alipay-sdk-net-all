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
        /// 券生效后N天内可以使用。 可以配合wait_days_after_receive字段使用。  限制： valid_days_after_receive必须大于0。
        /// </summary>
        [XmlElement("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 用户领券后需要等待N天，券才可以生效。  字段值为0表示用户领券后立刻生效。
        /// </summary>
        [XmlElement("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
