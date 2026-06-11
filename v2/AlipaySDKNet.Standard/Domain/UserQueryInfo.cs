using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserQueryInfo : AopObject
    {
        /// <summary>
        /// saas系统账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝登录账户的手机号,非患者手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// saas的虚拟uid
        /// </summary>
        [XmlElement("virtual_uid")]
        public string VirtualUid { get; set; }
    }
}
