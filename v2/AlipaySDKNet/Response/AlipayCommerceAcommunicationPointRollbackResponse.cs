using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointRollbackResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationPointRollbackResponse : AopResponse
    {
        /// <summary>
        /// 新积分id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
