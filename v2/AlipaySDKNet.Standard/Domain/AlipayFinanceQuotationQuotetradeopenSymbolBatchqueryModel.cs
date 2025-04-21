using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenSymbolBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenSymbolBatchqueryModel : AopObject
    {
        /// <summary>
        /// 股票唯一编码，symbol=code.market
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }
    }
}
