using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchQueryResponse.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务流水列表
        /// </summary>
        [XmlArray("task_flow_list")]
        [XmlArrayItem("ins_scene_task_flow_d_t_o")]
        public List<InsSceneTaskFlowDTO> TaskFlowList { get; set; }
    }
}
