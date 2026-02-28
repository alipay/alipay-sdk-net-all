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
        /// 优惠券有效期的取整方式，需与 valid_days_after_receive 字段配合使用，用于确定用户领取优惠券后的具体失效时间。  取值逻辑说明：ROUND_FORWARD（向前取整），优惠券在领取当日开始计算，于第 N 天（即 valid_days_after_receive 的值）的 当天 23:59:59 失效。  示例：  -若 valid_days_relative_type=ROUND_FORWARD，valid_days_after_receive=1，用户于 1 号 09:12:40 领券，则优惠券在 1 号 23:59:59 失效。  -若 valid_days_after_receive=2，则在 2 号 23:59:59 失效。ROUND_BACKWARD（向后取整），优惠券从领取次日开始计算，于第 N 天（即 valid_days_after_receive 的值）的 当天 23:59:59 失效。  示例：  -若valid_days_relative_type=ROUND_BACKWARDS，valid_days_after_receive=1，领券时间是1号9点12分40秒，那么 2 号 23:59:59 失效。  -若 valid_days_after_receive=2，则在 3 号 23:59:59 失效。
        /// </summary>
        [XmlElement("valid_days_relative_type")]
        public string ValidDaysRelativeType { get; set; }

        /// <summary>
        /// 用户领券后需要等待 N 天，券才可以生效。  字段值为 0 表示用户领券后立刻生效。
        /// </summary>
        [XmlElement("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
