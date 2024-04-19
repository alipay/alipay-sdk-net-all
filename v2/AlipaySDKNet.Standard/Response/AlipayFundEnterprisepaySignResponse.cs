using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundEnterprisepaySignResponse.
    /// </summary>
    public class AlipayFundEnterprisepaySignResponse : AopResponse
    {
        /// <summary>
        /// 签约凭证
        /// </summary>
        [XmlElement("sign_token")]
        public string SignToken { get; set; }

        /// <summary>
        /// 签约链接，用于跳转到开户页面
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
