using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftAssetNftidCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftAssetNftidCheckModel : AopObject
    {
        /// <summary>
        /// 用户账号
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型THIRD_UID博域
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// nftid客户的资产idmynftcore提供的
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
