using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertdocCertverifyPreconsultResponse.
    /// </summary>
    public class AlipayUserCertdocCertverifyPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 申请验证ID
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
