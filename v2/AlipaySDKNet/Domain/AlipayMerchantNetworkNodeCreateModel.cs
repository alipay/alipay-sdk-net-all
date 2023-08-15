using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantNetworkNodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantNetworkNodeCreateModel : AopObject
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
        /// 商家网络类型
        /// </summary>
        [XmlElement("network_type")]
        public string NetworkType { get; set; }

        /// <summary>
        /// 商家网络节点的类型，如城市，商圈, 商家
        /// </summary>
        [XmlElement("node_biz_type")]
        public string NodeBizType { get; set; }

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
