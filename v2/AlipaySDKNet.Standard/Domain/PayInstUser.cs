using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInstUser Data Structure.
    /// </summary>
    [Serializable]
    public class PayInstUser : AopObject
    {
        /// <summary>
        /// mobile_sha_256标识用户唯一信息，通过用户手机号SHA256 哈希后获得
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// 用户ID信息，该字段拼接方式：appID#openID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
