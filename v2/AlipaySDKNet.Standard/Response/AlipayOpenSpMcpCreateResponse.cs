using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpMcpCreateResponse.
    /// </summary>
    public class AlipayOpenSpMcpCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
