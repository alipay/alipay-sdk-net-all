using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 入库通知单id
        /// </summary>
        [XmlElement("inbound_order_id")]
        public string InboundOrderId { get; set; }
    }
}
