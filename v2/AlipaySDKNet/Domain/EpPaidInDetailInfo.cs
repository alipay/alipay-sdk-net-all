using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpPaidInDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpPaidInDetailInfo : AopObject
    {
        /// <summary>
        /// 认缴出资币种
        /// </summary>
        [XmlElement("paid_in_contributive_currency")]
        public string PaidInContributiveCurrency { get; set; }

        /// <summary>
        /// 认缴出资日期
        /// </summary>
        [XmlElement("paid_in_contributive_date")]
        public string PaidInContributiveDate { get; set; }

        /// <summary>
        /// 认缴出资额
        /// </summary>
        [XmlElement("paid_in_contributive_money")]
        public string PaidInContributiveMoney { get; set; }

        /// <summary>
        /// 认缴出资方式
        /// </summary>
        [XmlElement("paid_in_contributive_way")]
        public string PaidInContributiveWay { get; set; }
    }
}
