using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainTwcCertifyQueryResponse.
    /// </summary>
    public class AnttechBlockchainTwcCertifyQueryResponse : AopResponse
    {
        /// <summary>
        /// T:验证通过；F:验证不通过
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
