using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeTradedaystateBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeTradedaystateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 交易周期内的市场状态
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("trade_period_d_t_o")]
        public List<TradePeriodDTO> Data { get; set; }
    }
}
