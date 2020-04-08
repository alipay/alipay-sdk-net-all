using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserApplepayOtpSendResponse.
    /// </summary>
    public class AlipayUserApplepayOtpSendResponse : AopResponse
    {
        /// <summary>
        /// 响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
