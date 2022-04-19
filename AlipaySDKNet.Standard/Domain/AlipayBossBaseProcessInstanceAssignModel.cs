using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceAssignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceAssignModel : AopObject
    {
        /// <summary>
        /// 指派给谁(域账号)， assignee和assignee_work_no 二选一， assignee_work_no >assignee
        /// </summary>
        [XmlElement("assignee")]
        public string Assignee { get; set; }

        /// <summary>
        /// 指派给谁，工号(选填) assignee和assignee_work_no 二选一， assignee_work_no >assignee
        /// </summary>
        [XmlElement("assignee_work_no")]
        public string AssigneeWorkNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 流程实例节点
        /// </summary>
        [XmlElement("node")]
        public string Node { get; set; }

        /// <summary>
        /// 处理人ID,若未填写，则认为是系统处理(选填)
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [XmlElement("pu_id")]
        public string PuId { get; set; }

        /// <summary>
        /// 原任务处理人，普通任务留空，但若转交的是会签任务,则必填.仅将对应taskOperatorId的任务转交出去.且接收人只能是单人
        /// </summary>
        [XmlElement("task_operator_id")]
        public string TaskOperatorId { get; set; }
    }
}
