using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountQuotaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountQuotaInfo : AopObject
    {
        /// <summary>
        /// 剩余额度信息，单位为元
        /// </summary>
        [XmlElement("remain_money")]
        public string RemainMoney { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        [XmlElement("remain_times")]
        public string RemainTimes { get; set; }

        /// <summary>
        /// 对应交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
