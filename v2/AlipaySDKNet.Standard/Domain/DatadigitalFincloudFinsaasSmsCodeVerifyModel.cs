using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasSmsCodeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasSmsCodeVerifyModel : AopObject
    {
        /// <summary>
        /// 手机号加密字段
        /// </summary>
        [XmlElement("phone_num_encrypt")]
        public string PhoneNumEncrypt { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 手机验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }
    }
}
