using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftTransferApplyResponse.
    /// </summary>
    public class AnttechNftTransferApplyResponse : AopResponse
    {
        /// <summary>
        /// 流转的nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// 请求消息id，全链路唯一标记，建议打印，排查问题需提供
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 标识一类NFT
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
