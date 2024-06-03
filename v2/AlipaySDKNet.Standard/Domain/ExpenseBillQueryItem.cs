using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseBillQueryItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseBillQueryItem : AopObject
    {
        /// <summary>
        /// 费用明细列表
        /// </summary>
        [XmlElement("expense_list")]
        public ExpenseBillItem ExpenseList { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
