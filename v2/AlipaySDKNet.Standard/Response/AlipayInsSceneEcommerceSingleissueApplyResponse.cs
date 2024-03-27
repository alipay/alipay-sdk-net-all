using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceSingleissueApplyResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceSingleissueApplyResponse : AopResponse
    {
        /// <summary>
        /// 保单摘要数据
        /// </summary>
        [XmlElement("policy_digest")]
        public InsOpenPolicyDigestDTO PolicyDigest { get; set; }
    }
}
