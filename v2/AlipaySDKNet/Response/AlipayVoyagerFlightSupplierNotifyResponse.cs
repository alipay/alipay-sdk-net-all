using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerFlightSupplierNotifyResponse.
    /// </summary>
    public class AlipayVoyagerFlightSupplierNotifyResponse : AopResponse
    {
        /// <summary>
        /// 消费完成:CONSUME_SUCCESS 重新消费:RECONSUME_LATER
        /// </summary>
        [XmlElement("consume_status")]
        public string ConsumeStatus { get; set; }
    }
}
