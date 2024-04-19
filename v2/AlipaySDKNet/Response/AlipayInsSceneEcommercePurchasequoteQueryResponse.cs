using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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
        [XmlArray("purchase_query_results")]
        [XmlArrayItem("purchase_query_result_d_t_o")]
        public List<PurchaseQueryResultDTO> PurchaseQueryResults { get; set; }
    }
}
