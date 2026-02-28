using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithholdingDetail Data Structure.
    /// </summary>
    [Serializable]
    public class WithholdingDetail : AopObject
    {
        /// <summary>
        /// 应扣时间
        /// </summary>
        [XmlElement("due_time")]
        public string DueTime { get; set; }

        /// <summary>
        /// 扣款金额比较大时，一个周期多分多次扣款，通过这个字段告诉是否最好一次，默认值Y；取值Y/N
        /// </summary>
        [XmlElement("last_payment_period")]
        public string LastPaymentPeriod { get; set; }

        /// <summary>
        /// 代扣是第几期
        /// </summary>
        [XmlElement("period_number")]
        public long PeriodNumber { get; set; }

        /// <summary>
        /// 代扣金额,单位元，保留两位小数
        /// </summary>
        [XmlElement("withholding_amount")]
        public string WithholdingAmount { get; set; }
    }
}
