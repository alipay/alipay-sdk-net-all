using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantNetworkLeafnodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantNetworkLeafnodeCreateModel : AopObject
    {
        /// <summary>
        /// 节点的业务备注信息（如地址等信息）
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 商家的网络叶子节点ID，叶子节点ID一般为最后一个层级节点，在预付卡商家网络中对应的值为商户在直付通进件后的SMID账号
        /// </summary>
        [XmlElement("merchant_leafnode_id")]
        public string MerchantLeafnodeId { get; set; }

        /// <summary>
        /// 商家的网络叶子节点名称
        /// </summary>
        [XmlElement("merchant_leafnode_name")]
        public string MerchantLeafnodeName { get; set; }

        /// <summary>
        /// 商家网络类型
        /// </summary>
        [XmlElement("network_type")]
        public string NetworkType { get; set; }

        /// <summary>
        /// 增加当前商家的网络叶子节点ID的父节点ID
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
