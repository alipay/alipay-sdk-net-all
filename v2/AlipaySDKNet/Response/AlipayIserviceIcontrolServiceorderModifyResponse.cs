using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIcontrolServiceorderModifyResponse.
    /// </summary>
    public class AlipayIserviceIcontrolServiceorderModifyResponse : AopResponse
    {
        /// <summary>
        /// 服务单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
