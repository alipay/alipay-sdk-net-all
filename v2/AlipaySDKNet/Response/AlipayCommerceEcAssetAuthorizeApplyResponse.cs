using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAssetAuthorizeApplyResponse.
    /// </summary>
    public class AlipayCommerceEcAssetAuthorizeApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权跳转链接
        /// </summary>
        [XmlElement("authorize_link")]
        public string AuthorizeLink { get; set; }

        /// <summary>
        /// 当前授权状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
