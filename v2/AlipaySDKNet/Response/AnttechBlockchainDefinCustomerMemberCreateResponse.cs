using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberCreateResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberCreateResponse : AopResponse
    {
        /// <summary>
        /// 中台会员唯一ID
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
