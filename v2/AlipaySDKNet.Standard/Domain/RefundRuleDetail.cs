using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRuleDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRuleDetail : AopObject
    {
        /// <summary>
        /// 固定日期 当relativeDateType为ABSOLUTE时这个字段有值
        /// </summary>
        [XmlElement("absolute_date")]
        public string AbsoluteDate { get; set; }

        /// <summary>
        /// 取消时扣款金额计算基数 取消时扣款金额基数(首晚价格:FIRST_NIGHT_PRICE；订单总价:FULL_NIGHT_PRICE)， 实际扣款金额为 deductBaseType*decuctPercent
        /// </summary>
        [XmlElement("deduct_base_type")]
        public string DeductBaseType { get; set; }

        /// <summary>
        /// 取消时扣款比例(0.01-100.00)，实际扣款金额为 deductBaseType*deductPercent
        /// </summary>
        [XmlElement("deduct_percent")]
        public string DeductPercent { get; set; }

        /// <summary>
        /// 相对日期类别
        /// </summary>
        [XmlElement("relative_date_type")]
        public string RelativeDateType { get; set; }

        /// <summary>
        /// 对入住日提前分钟数 相对入住日提前的分钟数,当relativeDateType为CHECK_IN时这个字段有值,相对的是CHECK_IN日期的24点提前的分钟数。如入住日是2015-12-22号，则可取消时间是 2015-12-22 23:59:59 - relativeMinute 点之前可退
        /// </summary>
        [XmlElement("relative_minute")]
        public long RelativeMinute { get; set; }
    }
}
