using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateMultideductTokenApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateMultideductTokenApplyResponse : AopResponse
    {
        /// <summary>
        /// 校园支付token。用于跳转小程序开通或查询用户开通状态
        /// </summary>
        [XmlElement("token_id")]
        public string TokenId { get; set; }
    }
}
