using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateInfoParticipantCertifyResponse.
    /// </summary>
    public class AlipayCommerceEducateInfoParticipantCertifyResponse : AopResponse
    {
        /// <summary>
        /// 外部支付流水号
        /// </summary>
        [XmlElement("out_payid")]
        public string OutPayid { get; set; }
    }
}
