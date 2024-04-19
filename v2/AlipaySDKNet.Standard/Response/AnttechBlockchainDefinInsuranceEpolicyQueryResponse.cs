using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceEpolicyQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceEpolicyQueryResponse : AopResponse
    {
        /// <summary>
        /// 电子保单url地址
        /// </summary>
        [XmlElement("policy_url")]
        public string PolicyUrl { get; set; }
    }
}
