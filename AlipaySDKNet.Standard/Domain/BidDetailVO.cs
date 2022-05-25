using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BidDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class BidDetailVO : AopObject
    {
        /// <summary>
        /// 标的截止时间
        /// </summary>
        [XmlElement("bid_close_date")]
        public string BidCloseDate { get; set; }

        /// <summary>
        /// 标的持续时间（天）
        /// </summary>
        [XmlElement("bid_lasts_day")]
        public long BidLastsDay { get; set; }

        /// <summary>
        /// 标的名称
        /// </summary>
        [XmlElement("bid_name")]
        public string BidName { get; set; }

        /// <summary>
        /// 标的编号
        /// </summary>
        [XmlElement("bid_no")]
        public string BidNo { get; set; }

        /// <summary>
        /// 开标时间
        /// </summary>
        [XmlElement("bid_open_date")]
        public string BidOpenDate { get; set; }

        /// <summary>
        /// 标的类别
        /// </summary>
        [XmlElement("bid_type")]
        public string BidType { get; set; }

        /// <summary>
        /// 交易所编码
        /// </summary>
        [XmlElement("location_code")]
        public string LocationCode { get; set; }

        /// <summary>
        /// 交易所名称
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 标的所在省市
        /// </summary>
        [XmlElement("location_place")]
        public string LocationPlace { get; set; }
    }
}
