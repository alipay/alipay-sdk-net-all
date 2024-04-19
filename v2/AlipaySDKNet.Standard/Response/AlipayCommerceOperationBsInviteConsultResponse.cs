using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsInviteConsultResponse.
    /// </summary>
    public class AlipayCommerceOperationBsInviteConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否被邀约
        /// </summary>
        [XmlElement("invitable")]
        public bool Invitable { get; set; }
    }
}
