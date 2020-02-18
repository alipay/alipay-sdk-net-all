using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdFacepayVerifyResponse.
    /// </summary>
    public class AlipaySecurityProdFacepayVerifyResponse : AopResponse
    {
        /// <summary>
        /// 安全码。当人脸认证成功时，支付宝返回此项参数，商户使用此token发起后续支付流程
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }
    }
}
