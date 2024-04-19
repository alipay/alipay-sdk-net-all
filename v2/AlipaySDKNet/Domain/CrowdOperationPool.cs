using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdOperationPool Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdOperationPool : AopObject
    {
        /// <summary>
        /// 人群池编码
        /// </summary>
        [XmlElement("crowd_pool_code")]
        public string CrowdPoolCode { get; set; }

        /// <summary>
        /// 人群池类型
        /// </summary>
        [XmlElement("crowd_pool_type")]
        public string CrowdPoolType { get; set; }

        /// <summary>
        /// 池内计算类型
        /// </summary>
        [XmlElement("in_operation_type")]
        public string InOperationType { get; set; }

        /// <summary>
        /// 节点列表
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("crowd_operation_node")]
        public List<CrowdOperationNode> NodeList { get; set; }

        /// <summary>
        /// 池外计算类型
        /// </summary>
        [XmlElement("out_operation_type")]
        public string OutOperationType { get; set; }
    }
}
