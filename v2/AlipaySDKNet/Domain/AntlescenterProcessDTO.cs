using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntlescenterProcessDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AntlescenterProcessDTO : AopObject
    {
        /// <summary>
        /// 审批流其他信息
        /// </summary>
        [XmlElement("process_extra")]
        public string ProcessExtra { get; set; }

        /// <summary>
        /// 审批流程单号
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 审批流其他信息dto
        /// </summary>
        [XmlArray("process_info_list")]
        [XmlArrayItem("approval_flow_info")]
        public List<ApprovalFlowInfo> ProcessInfoList { get; set; }

        /// <summary>
        /// 审批流类型
        /// </summary>
        [XmlElement("process_type")]
        public string ProcessType { get; set; }
    }
}
