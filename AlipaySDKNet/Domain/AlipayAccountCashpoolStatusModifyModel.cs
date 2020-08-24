using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountCashpoolStatusModifyModel : AopObject
    {
        /// <summary>
        /// 资金池状态，INITIAL/RUN/STOP
        /// </summary>
        [XmlElement("adjust_status")]
        public string AdjustStatus { get; set; }

        /// <summary>
        /// 资金池ID
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
