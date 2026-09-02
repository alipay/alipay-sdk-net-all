using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FlexibleRentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FlexibleRentInfo : AopObject
    {
        /// <summary>
        /// 双周租金,单位:元
        /// </summary>
        [XmlElement("biweekly_rent")]
        public string BiweeklyRent { get; set; }

        /// <summary>
        /// 月度租金,单位:元
        /// </summary>
        [XmlElement("monthly_rent")]
        public string MonthlyRent { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pay_plan")]
        [XmlArrayItem("rent_pay_info")]
        public List<RentPayInfo> PayPlan { get; set; }

        /// <summary>
        /// 期数，按照最小维度来传（如果传了周租金，最小维度为周，以此类推）
        /// </summary>
        [XmlElement("period_count")]
        public long PeriodCount { get; set; }

        /// <summary>
        /// 季度租金，单位:元
        /// </summary>
        [XmlElement("quarterly_rent")]
        public string QuarterlyRent { get; set; }

        /// <summary>
        /// 灵活租期类型
        /// </summary>
        [XmlElement("rent_type")]
        public string RentType { get; set; }

        /// <summary>
        /// 10天租金,单位:元
        /// </summary>
        [XmlElement("ten_days_rent")]
        public string TenDaysRent { get; set; }

        /// <summary>
        /// 周租金,单位:元
        /// </summary>
        [XmlElement("weekly_rent")]
        public string WeeklyRent { get; set; }
    }
}
