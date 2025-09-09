using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherBudgetSupplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherBudgetSupplyInfo : AopObject
    {
        /// <summary>
        /// 【描述】营销资金预算类型 【枚举值】 免充值 : NO_CASH
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }
    }
}
