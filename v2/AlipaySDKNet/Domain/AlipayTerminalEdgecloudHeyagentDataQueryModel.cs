using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudHeyagentDataQueryModel : AopObject
    {
        /// <summary>
        /// 本次绘话的ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 望拿到的关键字
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

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
