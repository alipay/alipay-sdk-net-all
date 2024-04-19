using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountBalanceOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountBalanceOpenApiDTO : AopObject
    {
        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement("available_amount")]
        public MultiCurrencyMoneyOpenApi AvailableAmount { get; set; }

        /// <summary>
        /// 余额
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
