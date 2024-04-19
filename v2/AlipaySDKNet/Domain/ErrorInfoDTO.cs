using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ErrorInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorInfoDTO : AopObject
    {
        /// <summary>
        /// 联系人,一般为调用系统的owner
        /// </summary>
        [XmlElement("contact_user_id")]
        public string ContactUserId { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }
    }
}
