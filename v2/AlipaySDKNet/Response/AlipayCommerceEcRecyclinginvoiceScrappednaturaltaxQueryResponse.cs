using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceScrappednaturaltaxQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceScrappednaturaltaxQueryResponse : AopResponse
    {
        /// <summary>
        /// 自然人开票信息列表
        /// </summary>
        [XmlArray("invoice_amount_list")]
        [XmlArrayItem("natrual_person_invoice_amount_monthly")]
        public List<NatrualPersonInvoiceAmountMonthly> InvoiceAmountList { get; set; }
    }
}
