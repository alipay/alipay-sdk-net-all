using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasMemberInstQueryResponse.
    /// </summary>
    public class AlipayCommerceGasMemberInstQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构侧会员id
        /// </summary>
        [XmlElement("member_no")]
        public string MemberNo { get; set; }
    }
}
