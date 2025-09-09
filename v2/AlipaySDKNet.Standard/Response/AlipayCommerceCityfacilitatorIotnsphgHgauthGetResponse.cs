using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotnsphgHgauthGetResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorIotnsphgHgauthGetResponse : AopResponse
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授权信息
        /// </summary>
        [XmlElement("auth_content")]
        public string AuthContent { get; set; }
    }
}
