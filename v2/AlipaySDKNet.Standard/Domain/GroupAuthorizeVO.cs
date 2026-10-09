using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupAuthorizeVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupAuthorizeVO : AopObject
    {
        /// <summary>
        /// 授权记录id
        /// </summary>
        [XmlElement("authorize_id")]
        public string AuthorizeId { get; set; }

        /// <summary>
        /// 登录账号，脱敏后的邮箱账号或者手机账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识，只有当已授权的数据才会有相关的openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 授权状态，目前只有INIT、AUTHORIZED 两种状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 群授权类型，目前只有 GROUP_INSTANCE_ADMIN(群管理员授权)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户user_id，2088开头的16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称，脱敏后的名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
