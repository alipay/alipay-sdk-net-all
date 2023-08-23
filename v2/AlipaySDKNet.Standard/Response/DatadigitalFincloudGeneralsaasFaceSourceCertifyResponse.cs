using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceSourceCertifyResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceSourceCertifyResponse : AopResponse
    {
        /// <summary>
        /// 人脸认证单据号，用于认证问题排查
        /// </summary>
        [XmlElement("certify_no")]
        public string CertifyNo { get; set; }

        /// <summary>
        /// 认证不通过原因
        /// </summary>
        [XmlElement("mismatch_reason")]
        public string MismatchReason { get; set; }

        /// <summary>
        /// T：通过；F：不通过
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }

        /// <summary>
        /// double值，人脸图片质量分
        /// </summary>
        [XmlElement("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// double值，活体检测结果分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
