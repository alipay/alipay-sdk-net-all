using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftSkuCustomizeQueryResponse.
    /// </summary>
    public class AnttechNftSkuCustomizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 发放状态：WAITING待发放，FINISHED发放完成，CANCEL审核返回失败，FAILED无法发放，RECYCLE藏品被回收
        /// </summary>
        [XmlElement("distribution_status")]
        public string DistributionStatus { get; set; }

        /// <summary>
        /// 失败原因:UGC_ASSET_CAMP_USER_TYPE_CAN_NOT_AWARD企业用户不支持领取藏品,UGC_ASSET_CAMP_NFT_NO_INVENTORY自定义藏品无库存
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 藏品nftId
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }
    }
}
