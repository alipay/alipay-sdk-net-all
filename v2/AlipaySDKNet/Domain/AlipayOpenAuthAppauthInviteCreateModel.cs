using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppauthInviteCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppauthInviteCreateModel : AopObject
    {
        /// <summary>
        /// 指定授权的商户appid
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权回调地址，用于返回应用授权码
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 自定义参数，授权后回调时透传回服务商。对应的值必须为 base64 编码。
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
