using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftAssetSkuQueryResponse.
    /// </summary>
    public class AnttechNftAssetSkuQueryResponse : AopResponse
    {
        /// <summary>
        /// 藏品作者
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 发行方
        /// </summary>
        [XmlElement("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// 资产nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 藏品哈希值
        /// </summary>
        [XmlElement("sku_hash")]
        public string SkuHash { get; set; }

        /// <summary>
        /// 藏品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 藏品标颜色
        /// </summary>
        [XmlElement("sku_label_color")]
        public string SkuLabelColor { get; set; }

        /// <summary>
        /// 作品名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// 藏品缩略图链接
        /// </summary>
        [XmlElement("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
