using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FixedRentBillingRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FixedRentBillingRuleDTO : AopObject
    {
        /// <summary>
        /// 按期数时必填 只作展示
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 每期租金金额(单位元),最多2位小数 按期数时必填
        /// </summary>
        [XmlElement("period_rent_amount")]
        public string PeriodRentAmount { get; set; }

        /// <summary>
        /// 按期数时必填 分钟: MINUTE;小时: HOUR; 晚（酒店住宿用）: NIGHT; 天: DAY; 周: WEEK; 月: MONTH; 期: PERIOD
        /// </summary>
        [XmlElement("period_unit")]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// 按期数时必填 例：每期时间单位是分钟, 每期时间数值15, 那就是每15分钟是一个计费周期
        /// </summary>
        [XmlElement("period_unit_num")]
        public long PeriodUnitNum { get; set; }

        /// <summary>
        /// 最多2位小数， 类型固定FIXED时必填
        /// </summary>
        [XmlElement("rent_amount")]
        public string RentAmount { get; set; }

        /// <summary>
        /// 固定：FIXED 按期数：PERIOD
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
