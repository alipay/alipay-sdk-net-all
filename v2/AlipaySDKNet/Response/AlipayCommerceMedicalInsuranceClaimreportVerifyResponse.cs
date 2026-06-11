using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimreportVerifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceClaimreportVerifyResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("claim_result_list")]
        [XmlArrayItem("claim_result")]
        public List<ClaimResult> ClaimResultList { get; set; }

        /// <summary>
        /// 密钥，加密时使用
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }
    }
}
