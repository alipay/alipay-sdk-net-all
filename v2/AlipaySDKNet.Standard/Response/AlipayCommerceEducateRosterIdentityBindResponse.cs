using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateRosterIdentityBindResponse.
    /// </summary>
    public class AlipayCommerceEducateRosterIdentityBindResponse : AopResponse
    {
        /// <summary>
        /// 已绑定的支付宝账号
        /// </summary>
        [XmlElement("bind_alipay_account")]
        public string BindAlipayAccount { get; set; }
    }
}
