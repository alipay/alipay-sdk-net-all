using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DynamicRentBillingRuleSingleStageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DynamicRentBillingRuleSingleStageDTO : AopObject
    {
        /// <summary>
        /// 计费上限(单位元),最多2位小数
        /// </summary>
        [XmlElement("billing_cap")]
        public string BillingCap { get; set; }

        /// <summary>
        /// 期数单位为晚时使用,超过整点算一期,如果14则表示每日超过14点算一个新计费周期
        /// </summary>
        [XmlElement("cycle_hour")]
        public long CycleHour { get; set; }

        /// <summary>
        /// 每期租金(单位元),最多2位小数
        /// </summary>
        [XmlElement("period_rent_amount")]
        public string PeriodRentAmount { get; set; }

        /// <summary>
        /// 分钟: MINUTE;小时: HOUR; 晚（酒店住宿用）: NIGHT; 天: DAY; 周: WEEK; 月: MONTH;
        /// </summary>
        [XmlElement("period_unit")]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// 例：每期时间单位是分钟, 每期时间数值15, 那就是每15分钟是一个计费周期
        /// </summary>
        [XmlElement("period_unit_num")]
        public long PeriodUnitNum { get; set; }
    }
}
