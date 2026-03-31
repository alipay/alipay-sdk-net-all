using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAuctionBidInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAuctionBidInfoVO : AopObject
    {
        /// <summary>
        /// 竞拍平台买家的唯一标识
        /// </summary>
        [XmlElement("buyer_identify")]
        public string BuyerIdentify { get; set; }

        /// <summary>
        /// 买家名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 买家出价信息，币种：人民币 单位：元
        /// </summary>
        [XmlElement("buyer_price")]
        public string BuyerPrice { get; set; }
    }
}
