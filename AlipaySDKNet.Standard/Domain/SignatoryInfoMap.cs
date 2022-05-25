using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignatoryInfoMap Data Structure.
    /// </summary>
    [Serializable]
    public class SignatoryInfoMap : AopObject
    {
        /// <summary>
        /// 脱敏展示名，用于app展示
        /// </summary>
        [XmlElement("app_desens_display_name")]
        public string AppDesensDisplayName { get; set; }

        /// <summary>
        /// 用户头像路径
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 用户绑定手机
        /// </summary>
        [XmlElement("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 【证件号码】结合证件类型使用.【注意】只is_certified为T的时候才有意义，否则不保证准确性.
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// email登录名
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 是否通过实名认证。T/F
        /// </summary>
        [XmlElement("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 支付宝登录名
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 若用户是个人用户，则是用户的真实姓名；若是企业用户，则是企业名称。【注意】只有is_certified为T的时候才有意义，否则不保证准确性.
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户类型（1/2） 1代表公司账户2代表个人账户
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
