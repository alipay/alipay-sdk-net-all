using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceQueryResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回请求小目标实例集合
        /// </summary>
        [XmlArray("instances")]
        [XmlArrayItem("quest_instance_d_o")]
        public List<QuestInstanceDO> Instances { get; set; }
    }
}
