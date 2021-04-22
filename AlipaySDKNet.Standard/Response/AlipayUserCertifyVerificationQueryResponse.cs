using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyVerificationQueryResponse.
    /// </summary>
    public class AlipayUserCertifyVerificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 核验不一致原因
        /// </summary>
        [XmlElement("mismatch_reason")]
        public string MismatchReason { get; set; }

        /// <summary>
        /// 核验网络结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 核验源
        /// </summary>
        [XmlElement("source_from")]
        public string SourceFrom { get; set; }
    }
}
