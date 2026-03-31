using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAuctionMerchantInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAuctionMerchantInfoVO : AopObject
    {
        /// <summary>
        /// 竞拍商名称
        /// </summary>
        [XmlElement("auction_merchant_name")]
        public string AuctionMerchantName { get; set; }

        /// <summary>
        /// 竞拍商单号
        /// </summary>
        [XmlElement("auction_merchant_no")]
        public string AuctionMerchantNo { get; set; }

        /// <summary>
        /// 竞拍商PID
        /// </summary>
        [XmlElement("auction_merchant_pid")]
        public string AuctionMerchantPid { get; set; }
    }
}
