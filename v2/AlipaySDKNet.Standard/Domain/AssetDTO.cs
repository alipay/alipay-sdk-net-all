using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDTO : AopObject
    {
        /// <summary>
        /// 藏品创作者
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [XmlElement("index_id")]
        public long IndexId { get; set; }

        /// <summary>
        /// 藏品发行方
        /// </summary>
        [XmlElement("issue_name")]
        public string IssueName { get; set; }

        /// <summary>
        /// 缩略图URL
        /// </summary>
        [XmlElement("mini_image_url")]
        public string MiniImageUrl { get; set; }

        /// <summary>
        /// 资产nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 藏品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
