using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenTradeperiodBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenTradeperiodBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("obj_trading_period_d_t_o")]
        public List<ObjTradingPeriodDTO> Data { get; set; }
    }
}
