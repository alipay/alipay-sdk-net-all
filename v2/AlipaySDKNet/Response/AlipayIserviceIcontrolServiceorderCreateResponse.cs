using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIcontrolServiceorderCreateResponse.
    /// </summary>
    public class AlipayIserviceIcontrolServiceorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
