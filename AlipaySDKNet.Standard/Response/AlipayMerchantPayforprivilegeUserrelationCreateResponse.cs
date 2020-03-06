using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationCreateResponse : AopResponse
    {
        /// <summary>
        /// 充享惠业务用户与商户关系
        /// </summary>
        [XmlElement("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
