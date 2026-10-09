using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobInvitationSendResponse.
    /// </summary>
    public class AlipayEbppIndustryJobInvitationSendResponse : AopResponse
    {
        /// <summary>
        /// 邀约id
        /// </summary>
        [XmlElement("invitation_id")]
        public string InvitationId { get; set; }
    }
}
