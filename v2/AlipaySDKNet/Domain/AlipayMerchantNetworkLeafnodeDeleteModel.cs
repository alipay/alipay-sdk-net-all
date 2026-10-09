using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantNetworkLeafnodeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantNetworkLeafnodeDeleteModel : AopObject
    {
        /// <summary>
        /// 商家的网络叶子节点ID，叶子节点ID一般为最后一个层级节点，在预付卡商家网络中对应的值为商户在直付通进件后的SMID账号
        /// </summary>
        [XmlElement("merchant_leafnode_id")]
        public string MerchantLeafnodeId { get; set; }

        /// <summary>
        /// 商家网络类型
        /// </summary>
        [XmlElement("network_type")]
        public string NetworkType { get; set; }

        /// <summary>
        /// 商家网络的根节点，一般为总部企业账号PID （邀测阶段为商家与支付宝产生合作，由支付宝进行协商提供给商家）
        /// </summary>
        [XmlElement("root_id")]
        public string RootId { get; set; }
    }
}
