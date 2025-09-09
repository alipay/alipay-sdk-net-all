using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantBriefInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantBriefInfo : AopObject
    {
        /// <summary>
        /// 支付宝的商户号列表
        /// </summary>
        [XmlArray("merchant_list")]
        [XmlArrayItem("alipay_merchant_info")]
        public List<AlipayMerchantInfo> MerchantList { get; set; }

        /// <summary>
        /// 服务商侧商户编号
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }

        /// <summary>
        /// 设备绑定关系对列表，有设备时必传
        /// </summary>
        [XmlArray("sn_bind_pair_list")]
        [XmlArrayItem("device_relation_pair")]
        public List<DeviceRelationPair> SnBindPairList { get; set; }
    }
}
