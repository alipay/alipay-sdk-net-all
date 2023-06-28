using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasBcmDigitalrmbSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasBcmDigitalrmbSendModel : AopObject
    {
        /// <summary>
        /// 手机号密文
        /// </summary>
        [XmlElement("phone_num_encrypt")]
        public string PhoneNumEncrypt { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 广告投放页链接
        /// </summary>
        [XmlElement("web_page_url")]
        public string WebPageUrl { get; set; }
    }
}
