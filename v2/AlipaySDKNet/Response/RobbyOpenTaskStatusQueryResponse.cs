using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// RobbyOpenTaskStatusQueryResponse.
    /// </summary>
    public class RobbyOpenTaskStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("exception_info_list")]
        [XmlArrayItem("exception_info")]
        public List<ExceptionInfo> ExceptionInfoList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("object_task_status_list")]
        [XmlArrayItem("object_task_status")]
        public List<ObjectTaskStatus> ObjectTaskStatusList { get; set; }

        /// <summary>
        /// 子业务编号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }

        /// <summary>
        /// 灵波任务指令编号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }

        /// <summary>
        /// 任务接收状态，具体查看枚举值
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
