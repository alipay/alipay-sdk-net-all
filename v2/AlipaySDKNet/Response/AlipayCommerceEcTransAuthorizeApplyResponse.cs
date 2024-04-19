using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAuthorizeApplyResponse.
    /// </summary>
    public class AlipayCommerceEcTransAuthorizeApplyResponse : AopResponse
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 转账授权页面URL
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
