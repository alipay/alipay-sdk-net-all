using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmountItem Data Structure.
    /// </summary>
    [Serializable]
    public class AmountItem : AopObject
    {
        /// <summary>
        /// 余额，单位元
        /// </summary>
        [XmlElement("balance_amount")]
        public string BalanceAmount { get; set; }

        /// <summary>
        /// 币种，CNY-人民币
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 冻结余额，单位元
        /// </summary>
        [XmlElement("frozen_balance_amount")]
        public string FrozenBalanceAmount { get; set; }
    }
}
