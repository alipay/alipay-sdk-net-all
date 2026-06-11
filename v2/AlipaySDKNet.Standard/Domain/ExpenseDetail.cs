using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseDetail : AopObject
    {
        /// <summary>
        /// 费用明细
        /// </summary>
        [XmlElement("expense_detail_url")]
        public string ExpenseDetailUrl { get; set; }

        /// <summary>
        /// 费用结算id
        /// </summary>
        [XmlElement("settlement_id")]
        public string SettlementId { get; set; }
    }
}
