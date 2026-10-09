using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TreeNodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TreeNodeInfo : AopObject
    {
        /// <summary>
        /// 商家创建节点时需要携带的业务信息(比如地址)
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 商家的网络节点ID，一般为商家系统的公司，部门等关系之间的唯一ID
        /// </summary>
        [XmlElement("merchant_node_id")]
        public string MerchantNodeId { get; set; }

        /// <summary>
        /// 商家的网络节点名称
        /// </summary>
        [XmlElement("merchant_node_name")]
        public string MerchantNodeName { get; set; }

        /// <summary>
        /// 节点业务类型
        /// </summary>
        [XmlElement("node_biz_type")]
        public string NodeBizType { get; set; }
    }
}
