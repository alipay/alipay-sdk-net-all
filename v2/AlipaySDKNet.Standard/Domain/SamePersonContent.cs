using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SamePersonContent Data Structure.
    /// </summary>
    [Serializable]
    public class SamePersonContent : AopObject
    {
        /// <summary>
        /// 用户当前脱敏登录账号
        /// </summary>
        [XmlElement("cur_account_login_id")]
        public string CurAccountLoginId { get; set; }

        /// <summary>
        /// 用户当前脱敏支付账号
        /// </summary>
        [XmlElement("pay_account_login_id")]
        public string PayAccountLoginId { get; set; }

        /// <summary>
        /// 用户当前脱敏支付账号名称
        /// </summary>
        [XmlElement("pay_account_nick_name")]
        public string PayAccountNickName { get; set; }
    }
}
