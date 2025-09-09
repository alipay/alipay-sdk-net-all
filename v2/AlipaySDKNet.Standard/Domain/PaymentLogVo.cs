using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentLogVo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentLogVo : AopObject
    {
        /// <summary>
        /// 结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 支出总金额，单位分
        /// </summary>
        [XmlElement("expense_amount")]
        public long ExpenseAmount { get; set; }

        /// <summary>
        /// 支出次数
        /// </summary>
        [XmlElement("expense_count")]
        public long ExpenseCount { get; set; }

        /// <summary>
        /// 收入总金额，单位分
        /// </summary>
        [XmlElement("income_amount")]
        public long IncomeAmount { get; set; }

        /// <summary>
        /// 收入次数
        /// </summary>
        [XmlElement("income_count")]
        public long IncomeCount { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
