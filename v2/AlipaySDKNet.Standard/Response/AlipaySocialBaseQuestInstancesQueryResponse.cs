using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstancesQueryResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstancesQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户实例的查询结果集
        /// </summary>
        [XmlArray("instances")]
        [XmlArrayItem("quest_instance_d_t_o")]
        public List<QuestInstanceDTO> Instances { get; set; }
    }
}
