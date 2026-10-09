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
        /// 调用IoT核验源接口返回的额外信息，包括一级和二级策略返回码
        /// </summary>
        [XmlElement("extern_info")]
        public string ExternInfo { get; set; }

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
