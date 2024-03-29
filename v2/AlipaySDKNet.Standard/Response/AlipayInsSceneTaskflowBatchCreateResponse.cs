using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchCreateResponse.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务流水列表
        /// </summary>
        [XmlArray("task_flow_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskFlowIdList { get; set; }
    }
}
