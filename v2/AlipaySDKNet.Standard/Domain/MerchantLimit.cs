using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantLimit Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantLimit : AopObject
    {
        /// <summary>
        /// 限制的商户列表。商户的SMID或者PID。若想设置无限制类型，则只传单个ALL值
        /// </summary>
        [XmlArray("limit_merchant_list")]
        [XmlArrayItem("string")]
        public List<string> LimitMerchantList { get; set; }

        /// <summary>
        /// 限制类型： WHITELIST-白名单 BLACKLIST-黑名单
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }
    }
}
