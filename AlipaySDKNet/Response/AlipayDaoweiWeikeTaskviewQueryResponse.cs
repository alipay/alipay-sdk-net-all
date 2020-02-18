using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDaoweiWeikeTaskviewQueryResponse.
    /// </summary>
    public class AlipayDaoweiWeikeTaskviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 微客当前城市的任务视图列表
        /// </summary>
        [XmlArray("task_views")]
        [XmlArrayItem("weike_task_view")]
        public List<WeikeTaskView> TaskViews { get; set; }
    }
}
