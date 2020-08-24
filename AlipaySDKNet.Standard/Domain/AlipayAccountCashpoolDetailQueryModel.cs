using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolDetailQueryModel : AopObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }
    }
}
