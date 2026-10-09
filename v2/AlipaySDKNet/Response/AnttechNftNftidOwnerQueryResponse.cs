using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftNftidOwnerQueryResponse.
    /// </summary>
    public class AnttechNftNftidOwnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 藏品的 hash 值
        /// </summary>
        [XmlElement("mold_hash")]
        public string MoldHash { get; set; }

        /// <summary>
        /// 藏品的链上铸造时间
        /// </summary>
        [XmlElement("mold_time")]
        public string MoldTime { get; set; }

        /// <summary>
        /// 藏品的nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 藏品接收时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 持有人用户ID
        /// </summary>
        [XmlElement("third_id")]
        public string ThirdId { get; set; }
    }
}
