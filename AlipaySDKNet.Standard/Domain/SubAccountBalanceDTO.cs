using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountBalanceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountBalanceDTO : AopObject
    {
        /// <summary>
        /// 可用金额
        /// </summary>
        [XmlElement("available_amount")]
        public MultiCurrencyMoneyOpenApi AvailableAmount { get; set; }

        /// <summary>
        /// 总余额
        /// </summary>
        [XmlElement("balance")]
        public MultiCurrencyMoneyOpenApi Balance { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [XmlElement("freeze_amount")]
        public MultiCurrencyMoneyOpenApi FreezeAmount { get; set; }
    }
}
