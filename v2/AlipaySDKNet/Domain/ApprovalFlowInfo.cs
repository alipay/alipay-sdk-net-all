using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalFlowInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalFlowInfo : AopObject
    {
        /// <summary>
        /// 审批结果
        /// </summary>
        [XmlElement("approve_status")]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 审批时间
        /// </summary>
        [XmlElement("approve_time")]
        public string ApproveTime { get; set; }

        /// <summary>
        /// 审批人域账号
        /// </summary>
        [XmlElement("approver")]
        public string Approver { get; set; }

        /// <summary>
        /// 审批人真名
        /// </summary>
        [XmlElement("approver_name")]
        public string ApproverName { get; set; }

        /// <summary>
        /// 审批人花名
        /// </summary>
        [XmlElement("approver_nick_name")]
        public string ApproverNickName { get; set; }

        /// <summary>
        /// 审批流关联附件列表，list中的值为文件id，具有唯一性
        /// </summary>
        [XmlArray("attachement_list")]
        [XmlArrayItem("create_e_sign_task_file_v_o")]
        public List<CreateESignTaskFileVO> AttachementList { get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [XmlElement("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// 流程审批节点编号
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 审批环节
        /// </summary>
        [XmlElement("node")]
        public string Node { get; set; }
    }
}
