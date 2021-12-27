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
        /// 券生效后N天内可以使用。   限制： 1、创建活动时传入时间类型type为RELATIVE时可修改。 2、valid_days_after_receive必须大于0。 3、修改该时间，只允许延长，不允许缩短。
        /// </summary>
        [XmlElement("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 券可使用的结束时间。  格式为yyyy-MM-dd HH:mm:ss  限制： 1、创建活动时传入时间类型type为ABSOLUTE才能修改。 2、券可使用的结束时间valid_end_time 必须大于 券的发放结束时间publish_end_time 3、修改券可使用的结束时间，只能延长，不允许缩短。
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
