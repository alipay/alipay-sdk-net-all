using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAuthorizeAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAuthorizeAddModel : AopObject
    {
        /// <summary>
        /// 支付宝登录账号，邮箱号或者手机号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 授权类型，目前只有 GROUP_INSTANCE_ADMIN(支付宝粉丝群管权限的授权类型)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
