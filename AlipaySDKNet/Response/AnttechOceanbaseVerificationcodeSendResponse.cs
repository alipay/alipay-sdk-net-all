using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseVerificationcodeSendResponse.
    /// </summary>
    public class AnttechOceanbaseVerificationcodeSendResponse : AopResponse
    {
        /// <summary>
        /// 验证码类型枚举：MESSAGE_CODE短信验证码；EMAIL_CODE邮件验证码。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
