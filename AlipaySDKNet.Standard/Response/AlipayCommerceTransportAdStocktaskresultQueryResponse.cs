using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 库存查询结果
        /// </summary>
        [XmlElement("stock_task_result")]
        public StockTaskResult StockTaskResult { get; set; }
    }
}
