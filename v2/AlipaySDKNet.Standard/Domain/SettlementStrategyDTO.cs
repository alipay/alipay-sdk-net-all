using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettlementStrategyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SettlementStrategyDTO : AopObject
    {
        /// <summary>
        /// 结算币种
        /// </summary>
        [XmlElement("settlement_currency")]
        public string SettlementCurrency { get; set; }
    }
}
