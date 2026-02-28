using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenHkstockconnsymbolBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenHkstockconnsymbolBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 港股通静态数据响应信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("h_k_stock_conn_symbol_d_t_o")]
        public List<HKStockConnSymbolDTO> Data { get; set; }
    }
}
