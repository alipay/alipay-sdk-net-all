using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountNoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccountNoInfo : AopObject
    {
        /// <summary>
        /// ● 若传入logon_id，则查询用户名下所有已实名的、作为登录账号的支付宝账号 ● 若传入phone_id，则查询用户名下所有已实名的，以手机号作为登录账号以及以绑定了该手机号的支付宝账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 用户支付宝账号userId对应的openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
