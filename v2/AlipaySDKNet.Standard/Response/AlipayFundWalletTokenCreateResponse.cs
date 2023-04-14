using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletTokenCreateResponse.
    /// </summary>
    public class AlipayFundWalletTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 绑定凭证
        /// </summary>
        [XmlElement("bind_token")]
        public string BindToken { get; set; }

        /// <summary>
        /// 绑定链接
        /// </summary>
        [XmlElement("bind_url")]
        public string BindUrl { get; set; }
    }
}
