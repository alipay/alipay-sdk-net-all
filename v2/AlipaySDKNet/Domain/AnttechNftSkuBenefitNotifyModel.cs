using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuBenefitNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuBenefitNotifyModel : AopObject
    {
        /// <summary>
        /// NFT_ID / QR_STRING（为空时默认NFT_ID）
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// code_type为空或者code_type=NFT_ID时必填
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// code_type=QR_STRING时必填
        /// </summary>
        [XmlElement("qr_string")]
        public string QrString { get; set; }

        /// <summary>
        /// sku编码，纯数字
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
