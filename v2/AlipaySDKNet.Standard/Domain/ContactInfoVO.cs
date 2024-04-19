using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContactInfoVO : AopObject
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 加密内容，创单时由团购插件上传，内容为手机号加密内容，解密方式参考<a href="https://opendocs.alipay.com/mini/api/getphonenumber#%E8%8E%B7%E5%8F%96%E6%89%8B%E6%9C%BA%E5%8F%B7">获取手机号</a>中第五步
        /// </summary>
        [XmlElement("encryption_content")]
        public string EncryptionContent { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
