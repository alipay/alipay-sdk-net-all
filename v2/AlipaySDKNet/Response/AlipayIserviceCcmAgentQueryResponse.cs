using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentQueryResponse : AopResponse
    {
        /// <summary>
        /// 客服列表
        /// </summary>
        [XmlArray("agents")]
        [XmlArrayItem("agent_v_o")]
        public List<AgentVO> Agents { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
