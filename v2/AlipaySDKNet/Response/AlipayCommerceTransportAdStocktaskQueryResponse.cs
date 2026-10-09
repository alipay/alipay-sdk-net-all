using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 库存任务执行情况
        /// </summary>
        [XmlElement("stock_task")]
        public StockTask StockTask { get; set; }
    }
}
