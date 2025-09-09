using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PeriodPayBillingRuleDynamicDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PeriodPayBillingRuleDynamicDTO : AopObject
    {
        /// <summary>
        /// 期数单位为晚时使用,超过整点算一期,如果14则表示每日超过14点算一个新计费周期
        /// </summary>
        [XmlElement("cycle_hour")]
        public long CycleHour { get; set; }

        /// <summary>
        /// 扣款日期类型 （目前仅对 周/月 周期单位生效） 用户指定扣款日期：USER_APPOINT_DATE 商家指定扣款日期： MERCHANT_APPOINT_DATE 周、月情况必填
        /// </summary>
        [XmlElement("deduction_date_type")]
        public string DeductionDateType { get; set; }

        /// <summary>
        /// 周：1-7 月：1-31 周、月且商家指定扣款日期的情况下必填
        /// </summary>
        [XmlElement("deduction_day")]
        public long DeductionDay { get; set; }

        /// <summary>
        /// 指定首期扣款日期
        /// </summary>
        [XmlElement("down_payment_date")]
        public string DownPaymentDate { get; set; }

        /// <summary>
        /// 总周期数
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 最多2位小数, 数组大小等于计费期数
        /// </summary>
        [XmlArray("period_rent_amount_list")]
        [XmlArrayItem("price")]
        public List<string> PeriodRentAmountList { get; set; }

        /// <summary>
        /// 分钟: MINUTE; 小时: HOUR; 晚（酒店住宿用）: NIGHT; 天: DAY; 周: WEEK; 月: MONTH
        /// </summary>
        [XmlElement("period_unit")]
        public string PeriodUnit { get; set; }
    }
}
