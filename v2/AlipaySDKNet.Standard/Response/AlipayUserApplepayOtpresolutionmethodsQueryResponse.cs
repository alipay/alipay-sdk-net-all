using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserApplepayOtpresolutionmethodsQueryResponse.
    /// </summary>
    public class AlipayUserApplepayOtpresolutionmethodsQueryResponse : AopResponse
    {
        /// <summary>
        /// OpenApi的Otp校验方法负责对象
        /// </summary>
        [XmlElement("resolution_methods")]
        public OpenApiResolutionMethod ResolutionMethods { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
