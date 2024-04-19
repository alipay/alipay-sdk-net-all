using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiOrderlistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiOrderlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 出租车订单列表
        /// </summary>
        [XmlArray("taxi_order")]
        [XmlArrayItem("taxi_order")]
        public List<TaxiOrder> TaxiOrder { get; set; }
    }
}
