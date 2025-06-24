using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaInfoDTO : AopObject
    {
        /// <summary>
        /// 剩余额度
        /// </summary>
        [XmlElement("remain_money")]
        public string RemainMoney { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        [XmlElement("remain_times")]
        public string RemainTimes { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
