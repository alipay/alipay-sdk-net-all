using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasMemberInstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasMemberInstQueryModel : AopObject
    {
        /// <summary>
        /// 机构侧会员唯一标识
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
