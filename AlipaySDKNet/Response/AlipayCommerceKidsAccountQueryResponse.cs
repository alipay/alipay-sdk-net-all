using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceKidsAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceKidsAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 登陆名
        /// </summary>
        [XmlElement("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
