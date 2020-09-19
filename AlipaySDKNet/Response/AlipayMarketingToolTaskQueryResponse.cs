using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolTaskQueryResponse.
    /// </summary>
    public class AlipayMarketingToolTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 方案下的任务列表。
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("applet_task_v_o")]
        public List<AppletTaskVO> TaskList { get; set; }
    }
}
