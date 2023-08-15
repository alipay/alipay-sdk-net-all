using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantNetworkRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantNetworkRelationQueryModel : AopObject
    {
        /// <summary>
        /// 商家的网络节点ID，一般为商家系统的公司，部门等关系之间的一ID
        /// </summary>
        [XmlElement("merchant_node_id")]
        public string MerchantNodeId { get; set; }

        /// <summary>
        /// 商家网络类型
        /// </summary>
        [XmlElement("network_type")]
        public string NetworkType { get; set; }

        /// <summary>
        /// 增加当前商家的网络节点ID的父节点ID
        /// </summary>
        [XmlElement("parent_merchant_node_id")]
        public string ParentMerchantNodeId { get; set; }

        /// <summary>
        /// 商家网络的根节点，一般为总部企业账号PID （邀测阶段为商家与支付宝产生合作，由支付宝进行协商提供给商家）
        /// </summary>
        [XmlElement("root_id")]
        public string RootId { get; set; }
    }
}
