using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAbntaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAbntaskModifyModel : AopObject
    {
        /// <summary>
        /// 操作任务列表
        /// </summary>
        [XmlArray("operate_task_list")]
        [XmlArrayItem("operate_task")]
        public List<OperateTask> OperateTaskList { get; set; }

        /// <summary>
        /// 操作时间，yyyy-MM-dd HH:mm:ss格式的字符串，不传的话默认为当前时间
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 操作人id，操作人在开发者系统中的账号id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人昵称
        /// </summary>
        [XmlElement("operator_nick")]
        public string OperatorNick { get; set; }
    }
}
