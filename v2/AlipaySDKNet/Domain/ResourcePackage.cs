using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourcePackage Data Structure.
    /// </summary>
    [Serializable]
    public class ResourcePackage : AopObject
    {
        /// <summary>
        /// 币种  - CNY  - USD  - EUR
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 资源包名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价（分）
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 资源包规格CODE  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_basic_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_enterprise_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 资源包时间单位  - 1_M
        /// </summary>
        [XmlElement("time_unit")]
        public string TimeUnit { get; set; }

        /// <summary>
        /// 成交价格（分）
        /// </summary>
        [XmlElement("trade_price")]
        public string TradePrice { get; set; }
    }
}
