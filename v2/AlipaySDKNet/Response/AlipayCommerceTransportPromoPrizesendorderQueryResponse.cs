using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportPromoPrizesendorderQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportPromoPrizesendorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 发奖列表信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("prize_order_detail")]
        public List<PrizeOrderDetail> Data { get; set; }
    }
}
