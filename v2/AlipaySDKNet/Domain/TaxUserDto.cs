using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxUserDto Data Structure.
    /// </summary>
    [Serializable]
    public class TaxUserDto : AopObject
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("payee_user_open_id")]
        public string PayeeUserOpenId { get; set; }

        /// <summary>
        /// The unique ID that is assigned by the MPP to identify a user.
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// The ID that the user uses to log in to the MPP platform. The ID is assigned by the MPP and is desensitized.
        /// </summary>
        [XmlElement("user_login_id")]
        public string UserLoginId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public TaxUserNameDto UserName { get; set; }
    }
}
