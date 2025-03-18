using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftAssetNftidQueryResponse.
    /// </summary>
    public class AnttechNftAssetNftidQueryResponse : AopResponse
    {
        /// <summary>
        /// NFT的创作者名称
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// NFT的发行方名称
        /// </summary>
        [XmlElement("issuer_name")]
        public string IssuerName { get; set; }

        /// <summary>
        /// 缩略图url
        /// </summary>
        [XmlElement("mini_image_path")]
        public string MiniImagePath { get; set; }

        /// <summary>
        /// NFT资产的唯一编码
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// NFT商品的商品编码
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// NFT商品的名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }
    }
}
