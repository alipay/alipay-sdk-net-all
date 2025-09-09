using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpPaidDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpPaidDetailInfo : AopObject
    {
        /// <summary>
        /// 实缴出资币种
        /// </summary>
        [XmlElement("paid_contributive_currency")]
        public string PaidContributiveCurrency { get; set; }

        /// <summary>
        /// 实缴出资日期
        /// </summary>
        [XmlElement("paid_contributive_date")]
        public string PaidContributiveDate { get; set; }

        /// <summary>
        /// 实缴出资额
        /// </summary>
        [XmlElement("paid_contributive_money")]
        public string PaidContributiveMoney { get; set; }

        /// <summary>
        /// 实缴出资方式
        /// </summary>
        [XmlElement("paid_contributive_way")]
        public string PaidContributiveWay { get; set; }
    }
}
