using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdSpreadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdSpreadModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档 <a href="https://opendocs.alipay.com/open/04zfa9?pathHash=f4809e98">安全应用范围枚举</a> 未传值或传入渠道均非法时 采用默认渠道，默认渠道：支付结果页AA、繁星激励。 传入值时，以商户入参为准。
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 扩展人群
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 是否包含种子人群
        /// </summary>
        [XmlElement("is_include_seed")]
        public bool IsIncludeSeed { get; set; }

        /// <summary>
        /// 种子人群编号
        /// </summary>
        [XmlElement("seed_crowd_code")]
        public string SeedCrowdCode { get; set; }

        /// <summary>
        /// 扩展数量
        /// </summary>
        [XmlElement("spread_count")]
        public string SpreadCount { get; set; }
    }
}
