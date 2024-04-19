using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpFaceauthVerifyResponse.
    /// </summary>
    public class AlipayOpenMiniIcpFaceauthVerifyResponse : AopResponse
    {
        /// <summary>
        /// 人脸核验的凭证
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
