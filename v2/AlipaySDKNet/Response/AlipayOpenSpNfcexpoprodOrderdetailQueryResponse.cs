using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNfcexpoprodOrderdetailQueryResponse.
    /// </summary>
    public class AlipayOpenSpNfcexpoprodOrderdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("order_detail_list")]
        [XmlArrayItem("order_detail_open_api_response")]
        public List<OrderDetailOpenApiResponse> OrderDetailList { get; set; }

        /// <summary>
        /// NORMAL-普通订单，GROUP-组合单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}
