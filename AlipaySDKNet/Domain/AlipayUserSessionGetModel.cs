using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSessionGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSessionGetModel : AopObject
    {
        /// <summary>
        /// 代理的小程序appid，用于生成openId和unionId
        /// </summary>
        [XmlElement("agent_app_id")]
        public string AgentAppId { get; set; }

        /// <summary>
        /// 登录时调用my.authLogin获取的 code
        /// </summary>
        [XmlElement("login_code")]
        public string LoginCode { get; set; }
    }
}
