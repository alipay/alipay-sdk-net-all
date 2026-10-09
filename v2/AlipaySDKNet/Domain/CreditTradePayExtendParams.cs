using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditTradePayExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class CreditTradePayExtendParams : AopObject
    {
        /// <summary>
        /// 标识信用支付阶段
        /// </summary>
        [XmlElement("credit_trade_phase")]
        public string CreditTradePhase { get; set; }

        /// <summary>
        /// 标识信用支付场景
        /// </summary>
        [XmlElement("credit_trade_scene")]
        public string CreditTradeScene { get; set; }

        /// <summary>
        /// 企业支付解决方案
        /// </summary>
        [XmlElement("pay_solution")]
        public string PaySolution { get; set; }

        /// <summary>
        /// 支付解决方案场景
        /// </summary>
        [XmlElement("pay_solution_config")]
        public string PaySolutionConfig { get; set; }
    }
}
