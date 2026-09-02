using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeAwardDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TradeAwardDetail : AopObject
    {
        /// <summary>
        /// 激励金额，单位：分
        /// </summary>
        [XmlElement("award_amount")]
        public string AwardAmount { get; set; }

        /// <summary>
        /// 门店LEADSID
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 门店POIMID
        /// </summary>
        [XmlElement("poi_mid")]
        public string PoiMid { get; set; }

        /// <summary>
        /// 交易金额，单位：分
        /// </summary>
        [XmlElement("trade_amount")]
        public long TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
