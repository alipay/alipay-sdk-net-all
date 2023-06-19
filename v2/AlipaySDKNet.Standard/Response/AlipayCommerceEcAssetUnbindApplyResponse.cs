using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAssetUnbindApplyResponse.
    /// </summary>
    public class AlipayCommerceEcAssetUnbindApplyResponse : AopResponse
    {
        /// <summary>
        /// 取消授权链接
        /// </summary>
        [XmlElement("cancel_authorize_link")]
        public string CancelAuthorizeLink { get; set; }
    }
}
