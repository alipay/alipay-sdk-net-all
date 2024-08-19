using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherModifyUseTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherModifyUseTimeInfo : AopObject
    {
        /// <summary>
        /// 绝对核销时间
        /// </summary>
        [XmlElement("app_item_absolute_period_info")]
        public AppItemAbsoluteModifyPeriodInfo AppItemAbsolutePeriodInfo { get; set; }

        /// <summary>
        /// 相对核销时间
        /// </summary>
        [XmlElement("app_item_relative_period_info")]
        public AppItemRelativeModifyPeriodInfo AppItemRelativePeriodInfo { get; set; }
    }
}
