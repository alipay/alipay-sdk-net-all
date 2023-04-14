using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCertifyCertifyResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceCertifyCertifyResponse : AopResponse
    {
        /// <summary>
        /// 核验不一致原因
        /// </summary>
        [XmlElement("mismatch_reason")]
        public string MismatchReason { get; set; }

        /// <summary>
        /// 是否通过，通过为T，不通过为F
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
