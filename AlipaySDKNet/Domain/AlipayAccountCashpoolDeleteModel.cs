using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolDeleteModel : AopObject
    {
        /// <summary>
        /// 资金池ID
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
