using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNtaskSceneQueryResponse.
    /// </summary>
    public class AlipayOpenSpNtaskSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据参数查询到的任务作业信息列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("n_task_scene_detail")]
        public List<NTaskSceneDetail> TaskList { get; set; }
    }
}
