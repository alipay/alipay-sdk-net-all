using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndirectisvActivityEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndirectisvActivityEffectModel : AopObject
    {
        /// <summary>
        /// 活动生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户收单账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
