using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiShopWxloginQueryResponse.
    /// </summary>
    public class KoubeiShopWxloginQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户唯一标识的 openid
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 会话密钥
        /// </summary>
        [XmlElement("session_key")]
        public string SessionKey { get; set; }
    }
}
