using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasSmsCodeSendResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasSmsCodeSendResponse : AopResponse
    {
        /// <summary>
        /// 手机验证码失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 手机短信验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }
    }
}
