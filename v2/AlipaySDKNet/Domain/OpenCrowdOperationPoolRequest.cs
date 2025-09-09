using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCrowdOperationPoolRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCrowdOperationPoolRequest : AopObject
    {
        /// <summary>
        /// 组合内节点类型必须一致，都是标签，或者都是人群
        /// </summary>
        [XmlElement("crowd_pool_type")]
        public string CrowdPoolType { get; set; }

        /// <summary>
        /// 组合节点的计算类型，组合内标签求交集、求并集，或者组合内人群求交集、求并集
        /// </summary>
        [XmlElement("in_operation_type")]
        public string InOperationType { get; set; }

        /// <summary>
        /// 组合内的计算节点列表，如果是标签，则需要传入标签的标签信息、圈选项、圈选值，如果是人群，只需要传入人群编码
        /// </summary>
        [XmlArray("operation_node_list")]
        [XmlArrayItem("open_crowd_operation_node_request")]
        public List<OpenCrowdOperationNodeRequest> OperationNodeList { get; set; }

        /// <summary>
        /// 组合和其他组合的计算类型，支持交集、并集、差集三种方式。
        /// </summary>
        [XmlElement("out_operation_type")]
        public string OutOperationType { get; set; }
    }
}
