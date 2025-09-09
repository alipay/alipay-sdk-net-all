using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAuthorizeAddResponse.
    /// </summary>
    public class AlipayMerchantGroupAuthorizeAddResponse : AopResponse
    {
        /// <summary>
        /// 授权记录id
        /// </summary>
        [XmlElement("authorize_id")]
        public string AuthorizeId { get; set; }
    }
}
