using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipaySubscribeStatusCheckResponse.
    /// </summary>
    public class AlipayAipaySubscribeStatusCheckResponse : AopResponse
    {
        /// <summary>
        /// data为用户订单信息
        /// </summary>
        [XmlElement("data")]
        public SubscribeStatusApiResponse Data { get; set; }
    }
}
