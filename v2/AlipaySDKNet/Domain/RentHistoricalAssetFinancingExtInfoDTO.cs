using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentHistoricalAssetFinancingExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentHistoricalAssetFinancingExtInfoDTO : AopObject
    {
        /// <summary>
        /// 已还期数
        /// </summary>
        [XmlElement("paid_period")]
        public long PaidPeriod { get; set; }

        /// <summary>
        /// 已还租金，单位：元。
        /// </summary>
        [XmlElement("paid_price")]
        public string PaidPrice { get; set; }

        /// <summary>
        /// 开始融资期数
        /// </summary>
        [XmlElement("start_financing_period")]
        public long StartFinancingPeriod { get; set; }

        /// <summary>
        /// 剩余未还期数
        /// </summary>
        [XmlElement("unpaid_period")]
        public long UnpaidPeriod { get; set; }

        /// <summary>
        /// 剩余未还租金，单位：元。
        /// </summary>
        [XmlElement("unpaid_price")]
        public string UnpaidPrice { get; set; }
    }
}
