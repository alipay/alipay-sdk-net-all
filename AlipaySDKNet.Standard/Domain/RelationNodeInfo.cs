using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelationNodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RelationNodeInfo : AopObject
    {
        /// <summary>
        /// 节点名称，根据不同的关联关系类型，可能为企业名或者人名
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点编号，当product_code=uboQuery时，该字段为空
        /// </summary>
        [XmlElement("node_no")]
        public string NodeNo { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 关联关系类型
        /// </summary>
        [XmlElement("relation_code")]
        public string RelationCode { get; set; }

        /// <summary>
        /// 持股比例
        /// </summary>
        [XmlElement("ultimate_ratio")]
        public string UltimateRatio { get; set; }
    }
}
