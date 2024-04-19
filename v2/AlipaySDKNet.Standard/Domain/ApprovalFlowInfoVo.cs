using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalFlowInfoVo Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalFlowInfoVo : AopObject
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
        /// 审批人姓名
        /// </summary>
        [XmlElement("approver_name")]
        public string ApproverName { get; set; }

        /// <summary>
        /// 审批人花名
        /// </summary>
        [XmlElement("approver_nick_name")]
        public string ApproverNickName { get; set; }

        /// <summary>
        /// 审批流关联附件列表
        /// </summary>
        [XmlElement("attachement_list")]
        public AesElecSignFileDO AttachementList { get; set; }

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
        /// 审批节点
        /// </summary>
        [XmlElement("node")]
        public string Node { get; set; }
    }
}
