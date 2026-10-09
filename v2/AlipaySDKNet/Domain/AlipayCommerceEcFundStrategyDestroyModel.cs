using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcFundStrategyDestroyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcFundStrategyDestroyModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 出资方式唯一编号
        /// </summary>
        [XmlElement("strategy_id")]
        public string StrategyId { get; set; }
    }
}
