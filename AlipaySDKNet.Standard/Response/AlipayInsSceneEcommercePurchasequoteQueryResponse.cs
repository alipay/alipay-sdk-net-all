using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchasequoteQueryResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchasequoteQueryResponse : AopResponse
    {
        /// <summary>
        /// 订购查询结果
        /// </summary>
        [XmlElement("purchase_query_results")]
        public PurchaseQueryResultDTO PurchaseQueryResults { get; set; }
    }
}
