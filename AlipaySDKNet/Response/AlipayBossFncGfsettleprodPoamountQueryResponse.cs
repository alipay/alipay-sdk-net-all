using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPoamountQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodPoamountQueryResponse : AopResponse
    {
        /// <summary>
        /// 已开票金额
        /// </summary>
        [XmlElement("po_invoiced_amount")]
        public MultiCurrencyMoneyOpenApi PoInvoicedAmount { get; set; }

        /// <summary>
        /// 已认证开票金额
        /// </summary>
        [XmlElement("po_invoiced_auth_amount")]
        public MultiCurrencyMoneyOpenApi PoInvoicedAuthAmount { get; set; }

        /// <summary>
        /// 已付款金额
        /// </summary>
        [XmlElement("po_settled_amount")]
        public MultiCurrencyMoneyOpenApi PoSettledAmount { get; set; }
    }
}
