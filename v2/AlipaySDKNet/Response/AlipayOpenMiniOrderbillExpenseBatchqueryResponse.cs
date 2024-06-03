using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderbillExpenseBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderbillExpenseBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 费用查询结果
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("expense_bill_query_item")]
        public List<ExpenseBillQueryItem> ResultList { get; set; }
    }
}
