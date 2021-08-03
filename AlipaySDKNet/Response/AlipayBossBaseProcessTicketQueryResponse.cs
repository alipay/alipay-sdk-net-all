using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessTicketQueryResponse : AopResponse
    {
        /// <summary>
        /// 工单详情
        /// </summary>
        [XmlElement("ticket")]
        public BPOpenApiTicket Ticket { get; set; }
    }
}
