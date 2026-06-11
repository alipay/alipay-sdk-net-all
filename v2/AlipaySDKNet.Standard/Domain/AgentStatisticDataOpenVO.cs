using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentStatisticDataOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class AgentStatisticDataOpenVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("agent_statistic_data_item_open_v_o")]
        public List<AgentStatisticDataItemOpenVO> DataList { get; set; }
    }
}
