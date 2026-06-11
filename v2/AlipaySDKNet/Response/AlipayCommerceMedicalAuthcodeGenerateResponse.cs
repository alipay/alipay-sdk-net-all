using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthcodeGenerateResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthcodeGenerateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝返回给商户的授权认证码，用于后续换取token
        /// </summary>
        [XmlElement("authcode")]
        public string Authcode { get; set; }

        /// <summary>
        /// authcode过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
