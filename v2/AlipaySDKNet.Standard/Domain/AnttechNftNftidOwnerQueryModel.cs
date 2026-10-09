using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftNftidOwnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftNftidOwnerQueryModel : AopObject
    {
        /// <summary>
        /// 预测的持有用户id，可能为空
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 预测持有用户id类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 藏品的nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
