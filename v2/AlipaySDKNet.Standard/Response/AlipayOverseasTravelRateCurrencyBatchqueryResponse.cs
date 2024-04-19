using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelRateCurrencyBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTravelRateCurrencyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 汇率币种列表
        /// </summary>
        [XmlArray("currency_list")]
        [XmlArrayItem("rate_currency")]
        public List<RateCurrency> CurrencyList { get; set; }
    }
}
