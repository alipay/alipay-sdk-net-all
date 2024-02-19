using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpFaceauthQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIcpFaceauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 人脸核验结果描述，当certify_result_status为FAIL时展示失败的原因
        /// </summary>
        [XmlElement("certify_result_desc")]
        public string CertifyResultDesc { get; set; }

        /// <summary>
        /// 人脸核验结果状态
        /// </summary>
        [XmlElement("certify_result_status")]
        public string CertifyResultStatus { get; set; }
    }
}
