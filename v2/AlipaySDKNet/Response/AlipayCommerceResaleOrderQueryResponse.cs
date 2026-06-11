using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceResaleOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceResaleOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("data")]
        public ResaleOrderDetailVO Data { get; set; }
    }
}
