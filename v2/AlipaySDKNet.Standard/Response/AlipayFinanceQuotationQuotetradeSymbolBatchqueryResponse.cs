using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 码表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("symbol_d_t_o")]
        public List<SymbolDTO> Data { get; set; }
    }
}
