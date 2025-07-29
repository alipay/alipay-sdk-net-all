using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleAuthConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleAuthConfirmModel : AopObject
    {
        /// <summary>
        /// 用户的支付宝登陆号，可以是手机或邮箱
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
