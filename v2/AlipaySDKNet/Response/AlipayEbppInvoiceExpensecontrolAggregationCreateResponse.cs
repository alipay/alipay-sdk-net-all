using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolAggregationCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolAggregationCreateResponse : AopResponse
    {
        /// <summary>
        /// 费控聚合关系ID
        /// </summary>
        [XmlElement("aggregation_id")]
        public string AggregationId { get; set; }
    }
}
