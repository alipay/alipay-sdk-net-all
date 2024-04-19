using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdOperationNodeOptionGroup Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdOperationNodeOptionGroup : AopObject
    {
        /// <summary>
        /// 节点值编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 节点选项列表
        /// </summary>
        [XmlArray("node_option_list")]
        [XmlArrayItem("crowd_operation_node_option")]
        public List<CrowdOperationNodeOption> NodeOptionList { get; set; }
    }
}
