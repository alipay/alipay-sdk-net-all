using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAuctionInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAuctionInfoVO : AopObject
    {
        /// <summary>
        /// 竞拍出价信息
        /// </summary>
        [XmlElement("auction_bid_info_list")]
        public RecycleAuctionBidInfoVO AuctionBidInfoList { get; set; }

        /// <summary>
        /// 中标买家信息
        /// </summary>
        [XmlElement("auction_buyer_info")]
        public RecycleAuctionBuyerInfoVO AuctionBuyerInfo { get; set; }

        /// <summary>
        /// 竞拍履约信息
        /// </summary>
        [XmlElement("auction_delivery_info")]
        public RecycleAuctionDeliveryInfoVO AuctionDeliveryInfo { get; set; }

        /// <summary>
        /// 中标竞拍商的信息
        /// </summary>
        [XmlElement("auction_merchant_info")]
        public RecycleAuctionMerchantInfoVO AuctionMerchantInfo { get; set; }

        /// <summary>
        /// 竞拍中标价格，币种：人民币 单位：元
        /// </summary>
        [XmlElement("auction_price")]
        public string AuctionPrice { get; set; }

        /// <summary>
        /// 竞拍状态
        /// </summary>
        [XmlElement("auction_status")]
        public string AuctionStatus { get; set; }

        /// <summary>
        /// 分账给履约商的金额，币种：人民币  单位：元
        /// </summary>
        [XmlElement("delivery_amount")]
        public string DeliveryAmount { get; set; }

        /// <summary>
        /// 向竞价平台抽佣的金额，币种：人民币  单位：元
        /// </summary>
        [XmlElement("fee_amount")]
        public string FeeAmount { get; set; }

        /// <summary>
        /// 结算给用户的金额，币种：人民币  单位：元
        /// </summary>
        [XmlElement("user_amount")]
        public string UserAmount { get; set; }
    }
}
