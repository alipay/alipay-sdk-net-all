using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillApiStatisticInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillApiStatisticInfo : AopObject
    {
        /// <summary>
        /// 按照账单的规则进行统计得到的支出金额，单位元
        /// </summary>
        [XmlElement("expenditure_amount")]
        public string ExpenditureAmount { get; set; }

        /// <summary>
        /// 按照账单的规则进行统计得到的收入金额，单位元
        /// </summary>
        [XmlElement("income_amount")]
        public string IncomeAmount { get; set; }
    }
}
