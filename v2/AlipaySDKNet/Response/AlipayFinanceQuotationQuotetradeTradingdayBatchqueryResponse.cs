using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeTradingdayBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeTradingdayBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 交易日数据, 格式为 yyyyMMdd. 逆序排序
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<string> Data { get; set; }
    }
}
