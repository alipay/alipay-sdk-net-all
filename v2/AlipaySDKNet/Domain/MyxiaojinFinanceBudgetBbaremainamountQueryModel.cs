using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MyxiaojinFinanceBudgetBbaremainamountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MyxiaojinFinanceBudgetBbaremainamountQueryModel : AopObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }
    }
}
