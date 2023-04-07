using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenCloudAppSecCreateResponse.
    /// </summary>
    public class AlipayOpenCloudAppSecCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝公钥
        /// </summary>
        [XmlElement("alipay_public_key")]
        public string AlipayPublicKey { get; set; }
    }
}
