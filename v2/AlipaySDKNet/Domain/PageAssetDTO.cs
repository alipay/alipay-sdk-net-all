using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageAssetDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PageAssetDTO : AopObject
    {
        /// <summary>
        /// 资产场景
        /// </summary>
        [XmlElement("asset_scene")]
        public string AssetScene { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 发行方
        /// </summary>
        [XmlElement("issuer_name")]
        public string IssuerName { get; set; }

        /// <summary>
        /// 所属路途
        /// </summary>
        [XmlElement("mini_image_path")]
        public string MiniImagePath { get; set; }

        /// <summary>
        /// nftId资产的id
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// skuid  sku的专属id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }
    }
}
