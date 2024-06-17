using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCrowdOperationNodeRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCrowdOperationNodeRequest : AopObject
    {
        /// <summary>
        /// 如果计算节点类型是「tag 标签」，则传入「标签编码」，如果计算节点类型是「crowd 人群」，则传入「人群编码」
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 棋盘人群计算节点类型，支持「标签」和「人群」两种类型。
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 如果节点类型是「标签」，需要传入标签圈选值，如果节点类型是「人群」，不需要传入数据
        /// </summary>
        [XmlArray("operation_option_list")]
        [XmlArrayItem("open_crowd_operation_option_request")]
        public List<OpenCrowdOperationOptionRequest> OperationOptionList { get; set; }
    }
}
