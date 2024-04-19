using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceClaimApplyResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceClaimApplyResponse : AopResponse
    {
        /// <summary>
        /// 理赔单摘要
        /// </summary>
        [XmlElement("claim_digest")]
        public InsOpenClaimDigestDTO ClaimDigest { get; set; }
    }
}
