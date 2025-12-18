using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRentindustryItemBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppRentindustryItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("merchant_spu_query_result")]
        public List<MerchantSpuQueryResult> Data { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }
    }
}
