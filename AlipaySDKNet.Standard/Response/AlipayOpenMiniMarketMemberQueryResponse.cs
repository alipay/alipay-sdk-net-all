using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMarketMemberQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMarketMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 会员入会链接
        /// </summary>
        [XmlElement("membership_redirect_url")]
        public string MembershipRedirectUrl { get; set; }
    }
}
