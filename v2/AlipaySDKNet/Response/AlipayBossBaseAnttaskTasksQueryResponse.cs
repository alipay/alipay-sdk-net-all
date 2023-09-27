using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseAnttaskTasksQueryResponse.
    /// </summary>
    public class AlipayBossBaseAnttaskTasksQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回是否正确
        /// </summary>
        [XmlElement("boolean_result")]
        public TaskOperateResult BooleanResult { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("entities")]
        [XmlArrayItem("ant_task")]
        public List<AntTask> Entities { get; set; }

        /// <summary>
        /// 任务的总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
