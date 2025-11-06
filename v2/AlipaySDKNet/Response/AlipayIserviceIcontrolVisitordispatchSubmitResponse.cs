using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIcontrolVisitordispatchSubmitResponse.
    /// </summary>
    public class AlipayIserviceIcontrolVisitordispatchSubmitResponse : AopResponse
    {
        /// <summary>
        /// 统一收单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 排队位置
        /// </summary>
        [XmlElement("order_position")]
        public string OrderPosition { get; set; }
    }
}
