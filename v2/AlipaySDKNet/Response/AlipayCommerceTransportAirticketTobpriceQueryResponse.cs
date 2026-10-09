using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAirticketTobpriceQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAirticketTobpriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 机票价格信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("airticket_price_query_info")]
        public List<AirticketPriceQueryInfo> Data { get; set; }

        /// <summary>
        /// 外部订单号，与请求中的保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
