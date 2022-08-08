using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseTimeInfo : AopObject
    {
        /// <summary>
        /// 券绝对时间可用
        /// </summary>
        [XmlElement("absolute_period_info")]
        public VoucherAbsolutePeriodInfo AbsolutePeriodInfo { get; set; }

        /// <summary>
        /// 券有效期。  枚举值：  ABSOLUTE：绝对时间  RELATIVE：相对时间
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 券相对时间
        /// </summary>
        [XmlElement("relative_period_info")]
        public VoucherRelativePeriodInfo RelativePeriodInfo { get; set; }
    }
}
