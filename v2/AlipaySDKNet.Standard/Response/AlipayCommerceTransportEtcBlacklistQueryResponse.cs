using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcBlacklistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcBlacklistQueryResponse : AopResponse
    {
        /// <summary>
        /// ETC_ADVANCE_OVERTIME
        /// </summary>
        [XmlElement("blacklist_code")]
        public string BlacklistCode { get; set; }

        /// <summary>
        /// 垫资超期未还
        /// </summary>
        [XmlElement("blacklist_desc")]
        public string BlacklistDesc { get; set; }

        /// <summary>
        /// 黑名单状态：（无数据）NONE、（入黑状态）BLACKLIST_IN、（出黑状态）BLACKLIST_OUT
        /// </summary>
        [XmlElement("blacklist_status")]
        public string BlacklistStatus { get; set; }

        /// <summary>
        /// 最近入黑名单时间
        /// </summary>
        [XmlElement("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 最近出黑名单时间
        /// </summary>
        [XmlElement("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
