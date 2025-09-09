using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQueryBudgetSupplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQueryBudgetSupplyInfo : AopObject
    {
        /// <summary>
        /// 出资方式
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }
    }
}
