using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAutocheckTaskQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAutocheckTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务执行状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 云测 报告详情
        /// </summary>
        [XmlElement("express_task_detail")]
        public string ExpressTaskDetail { get; set; }

        /// <summary>
        /// SLM 报告详情
        /// </summary>
        [XmlArray("task_detail_vos")]
        [XmlArrayItem("one_stop_check_task_detail_d_t_o")]
        public List<OneStopCheckTaskDetailDTO> TaskDetailVos { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }
    }
}
