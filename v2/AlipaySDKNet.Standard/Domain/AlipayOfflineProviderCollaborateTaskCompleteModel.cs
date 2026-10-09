using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateTaskCompleteModel : AopObject
    {
        /// <summary>
        /// 当前操作在业务系统实际发生的时间。
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 完成返回内容列表
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("collaborate_task_complete_content")]
        public List<CollaborateTaskCompleteContent> Contents { get; set; }

        /// <summary>
        /// 外部系统对应操作流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拉取任务时获得的任务号。
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
