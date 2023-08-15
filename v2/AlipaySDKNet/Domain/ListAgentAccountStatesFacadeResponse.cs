using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ListAgentAccountStatesFacadeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ListAgentAccountStatesFacadeResponse : AopObject
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 坐席列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("agent_account_states")]
        public List<AgentAccountStates> List { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
