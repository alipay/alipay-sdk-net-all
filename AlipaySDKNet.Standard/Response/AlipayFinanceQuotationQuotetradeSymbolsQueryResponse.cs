using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolsQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolsQueryResponse : AopResponse
    {
        /// <summary>
        /// 股票的唯一代码：symbol=code.market
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<string> Data { get; set; }
    }
}
