using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardInstanceQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡信息
        /// </summary>
        [XmlElement("data")]
        public TimeCardInfo Data { get; set; }
    }
}
