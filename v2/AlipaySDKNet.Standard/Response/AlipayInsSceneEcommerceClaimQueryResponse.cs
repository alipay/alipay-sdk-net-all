using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceClaimQueryResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceClaimQueryResponse : AopResponse
    {
        /// <summary>
        /// 理赔单摘要
        /// </summary>
        [XmlArray("claim_list")]
        [XmlArrayItem("ins_open_claim_digest_d_t_o")]
        public List<InsOpenClaimDigestDTO> ClaimList { get; set; }
    }
}
