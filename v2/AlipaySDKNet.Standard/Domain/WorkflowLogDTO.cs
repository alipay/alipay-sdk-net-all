using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkflowLogDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WorkflowLogDTO : AopObject
    {
        /// <summary>
        /// 审批角色
        /// </summary>
        [XmlElement("approval_role")]
        public string ApprovalRole { get; set; }

        /// <summary>
        /// 审批时间
        /// </summary>
        [XmlElement("approve_time")]
        public string ApproveTime { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        [XmlElement("approver")]
        public PersonDTO Approver { get; set; }

        /// <summary>
        /// 审批附件
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("file_d_t_o")]
        public List<FileDTO> Attachments { get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [XmlElement("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// 审批动作
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }
    }
}
