using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAlipaypointBudgetlibQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAlipaypointBudgetlibQueryModel : AopObject
    {
        /// <summary>
        /// 集分宝预算库编码
        /// </summary>
        [XmlElement("budget_code")]
        public string BudgetCode { get; set; }
    }
}
