using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenDeleteResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenDeleteResponse : AopResponse
    {
        /// <summary>
        /// 响应报文头部
        /// </summary>
        [XmlElement("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }
    }
}
