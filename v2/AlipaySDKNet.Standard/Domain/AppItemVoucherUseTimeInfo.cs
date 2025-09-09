using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherUseTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherUseTimeInfo : AopObject
    {
        /// <summary>
        /// 绝对核销时间
        /// </summary>
        [XmlElement("app_item_absolute_period_info")]
        public AppItemAbsolutePeriodInfo AppItemAbsolutePeriodInfo { get; set; }

        /// <summary>
        /// 相对核销时间
        /// </summary>
        [XmlElement("app_item_relative_period_info")]
        public AppItemRelativePeriodInfo AppItemRelativePeriodInfo { get; set; }

        /// <summary>
        /// 【描述】券有效期 【枚举值】 绝对时间 : ABSOLUTE 相对时间: RELATIVE
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }
    }
}
