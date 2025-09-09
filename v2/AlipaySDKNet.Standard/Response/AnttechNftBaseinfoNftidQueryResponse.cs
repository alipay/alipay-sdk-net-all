using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftBaseinfoNftidQueryResponse.
    /// </summary>
    public class AnttechNftBaseinfoNftidQueryResponse : AopResponse
    {
        /// <summary>
        /// 发行hash
        /// </summary>
        [XmlElement("nft_hash")]
        public string NftHash { get; set; }

        /// <summary>
        /// 商家后台产品的nft_id
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 发行时间
        /// </summary>
        [XmlElement("nft_issue_time")]
        public string NftIssueTime { get; set; }
    }
}
