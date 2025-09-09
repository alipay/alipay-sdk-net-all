using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantGroupAutoreplyCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 自动回复id
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }
    }
}
