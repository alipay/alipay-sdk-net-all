using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftAssetSkuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftAssetSkuQueryModel : AopObject
    {
        /// <summary>
        /// 资产nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
