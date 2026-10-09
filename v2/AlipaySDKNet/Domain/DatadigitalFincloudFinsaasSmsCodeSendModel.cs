using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasSmsCodeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasSmsCodeSendModel : AopObject
    {
        /// <summary>
        /// 手机号密文，SM4加密
        /// </summary>
        [XmlElement("phone_num_encrypt")]
        public string PhoneNumEncrypt { get; set; }

        /// <summary>
        /// 短信发送场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
