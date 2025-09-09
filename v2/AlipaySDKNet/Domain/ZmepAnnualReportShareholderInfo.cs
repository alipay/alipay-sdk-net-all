using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAnnualReportShareholderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAnnualReportShareholderInfo : AopObject
    {
        /// <summary>
        /// 实缴出资时间
        /// </summary>
        [XmlElement("paid_contributive_date")]
        public string PaidContributiveDate { get; set; }

        /// <summary>
        /// 实缴出资额（万元）
        /// </summary>
        [XmlElement("paid_contributive_money")]
        public string PaidContributiveMoney { get; set; }

        /// <summary>
        /// 实缴出资方式
        /// </summary>
        [XmlElement("paid_contributive_way")]
        public string PaidContributiveWay { get; set; }

        /// <summary>
        /// 认缴出资时间
        /// </summary>
        [XmlElement("paid_in_contributive_date")]
        public string PaidInContributiveDate { get; set; }

        /// <summary>
        /// 认缴出资额（万元）
        /// </summary>
        [XmlElement("paid_in_contributive_money")]
        public string PaidInContributiveMoney { get; set; }

        /// <summary>
        /// 认缴出资方式
        /// </summary>
        [XmlElement("paid_in_contributive_way")]
        public string PaidInContributiveWay { get; set; }

        /// <summary>
        /// 股东
        /// </summary>
        [XmlElement("shareholder")]
        public string Shareholder { get; set; }
    }
}
