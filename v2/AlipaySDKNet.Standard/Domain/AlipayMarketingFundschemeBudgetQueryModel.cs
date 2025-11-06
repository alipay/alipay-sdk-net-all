using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingFundschemeBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingFundschemeBudgetQueryModel : AopObject
    {
        /// <summary>
        /// 资金池id，传入资金池id后，返回对应的资金池详细信息
        /// </summary>
        [XmlElement("fund_scheme_id")]
        public string FundSchemeId { get; set; }
    }
}
