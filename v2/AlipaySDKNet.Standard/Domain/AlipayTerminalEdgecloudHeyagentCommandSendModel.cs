using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentCommandSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudHeyagentCommandSendModel : AopObject
    {
        /// <summary>
        /// 本次绘话的ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// RPA命令，点击滑动输入等
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 向谁发送命令 目前有两个字符串类型的枚举"native""cloud"
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户设备的唯一标识
        /// </summary>
        [XmlElement("utdid")]
        public string Utdid { get; set; }
    }
}
