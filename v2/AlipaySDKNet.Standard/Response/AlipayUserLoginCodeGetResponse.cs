using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserLoginCodeGetResponse.
    /// </summary>
    public class AlipayUserLoginCodeGetResponse : AopResponse
    {
        /// <summary>
        /// 用户登录凭证（有效期五分钟）。开发者需要在开发者服务器后台调用 alipay.user.session.get，使用 loginCode 换取 openid、unionid等信息。
        /// </summary>
        [XmlElement("login_code")]
        public string LoginCode { get; set; }
    }
}
