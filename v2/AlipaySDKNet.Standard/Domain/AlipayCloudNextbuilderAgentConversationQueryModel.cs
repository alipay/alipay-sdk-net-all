using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentConversationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudNextbuilderAgentConversationQueryModel : AopObject
    {
        /// <summary>
        /// 青蓝平台创建的Agent 的 id，可从青蓝平台页面获取
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 开始时间戳，闭区间
        /// </summary>
        [XmlElement("from_time")]
        public long FromTime { get; set; }

        /// <summary>
        /// 实际用户标识
        /// </summary>
        [XmlElement("outer_user_id")]
        public string OuterUserId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 结束时间戳，开区间
        /// </summary>
        [XmlElement("to_time")]
        public long ToTime { get; set; }
    }
}
