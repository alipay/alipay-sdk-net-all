using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserLoginCodeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserLoginCodeGetModel : AopObject
    {
        /// <summary>
        /// 代理的小程序appid，用于生成openId和unionId
        /// </summary>
        [XmlElement("agent_app_id")]
        public string AgentAppId { get; set; }

        /// <summary>
        /// 代理的小程序pid，用于生成loginCode
        /// </summary>
        [XmlElement("agent_pid")]
        public string AgentPid { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("agent_user_id")]
        public string AgentUserId { get; set; }
    }
}
