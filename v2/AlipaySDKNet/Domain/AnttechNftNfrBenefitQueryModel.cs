using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftNfrBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftNfrBenefitQueryModel : AopObject
    {
        /// <summary>
        /// NFT_ID / QR_STRING（为空时默认NFT_ID）
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// NFT标识，codeType=NFT_ID时必填
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 12位随机字母数字，codeType=QR_STRING时必填
        /// </summary>
        [XmlElement("qr_string")]
        public string QrString { get; set; }

        /// <summary>
        /// SKU编码，纯数字
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
