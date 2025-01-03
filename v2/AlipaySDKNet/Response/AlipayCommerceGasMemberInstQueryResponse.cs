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

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
