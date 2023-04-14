using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApproveNodePageGroupDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApproveNodePageGroupDTO : AopObject
    {
        /// <summary>
        /// 审批流操作groupId
        /// </summary>
        [XmlElement("ant_process_group_puid")]
        public string AntProcessGroupPuid { get; set; }

        /// <summary>
        /// 审批流分组列表
        /// </summary>
        [XmlArray("approve_node_group_list")]
        [XmlArrayItem("node_operate_d_t_o")]
        public List<NodeOperateDTO> ApproveNodeGroupList { get; set; }
    }
}
