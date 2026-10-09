using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantInfoDTO : AopObject
    {
        /// <summary>
        /// 品牌id（统一权益池的品牌id）
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// mcc编码
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
