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
        /// 股权穿透持股比：当关联关系类型为 ubo 时，该值代表最终受益人到被查公司各路径的股权穿透持股比
        /// </summary>
        [XmlElement("equity_penetration_ratio")]
        public string EquityPenetrationRatio { get; set; }

        /// <summary>
        /// 当前节点的层数
        /// </summary>
        [XmlElement("layer")]
        public long Layer { get; set; }

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
        /// 持股比例：当关联关系类型为 ubo 时，该值为最终受益人相对于被查公司的受益持股比例（基于银发235号文、164号文的定义计算所得）
        /// </summary>
        [XmlElement("ultimate_ratio")]
        public string UltimateRatio { get; set; }
    }
}
