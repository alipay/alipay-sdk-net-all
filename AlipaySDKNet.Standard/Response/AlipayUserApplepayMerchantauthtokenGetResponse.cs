using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserApplepayMerchantauthtokenGetResponse.
    /// </summary>
    public class AlipayUserApplepayMerchantauthtokenGetResponse : AopResponse
    {
        /// <summary>
        /// 商户授权token
        /// </summary>
        [XmlElement("merchant_auth_token")]
        public string MerchantAuthToken { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
