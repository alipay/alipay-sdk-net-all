using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePremiumPaySyncResponse.
    /// </summary>
    public class AlipayInsScenePremiumPaySyncResponse : AopResponse
    {
        /// <summary>
        /// 保单摘要
        /// </summary>
        [XmlElement("policy_digest")]
        public InsOpenPolicyDigestDTO PolicyDigest { get; set; }
    }
}
