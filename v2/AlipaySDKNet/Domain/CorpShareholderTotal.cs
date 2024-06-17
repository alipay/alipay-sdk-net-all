using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpShareholderTotal Data Structure.
    /// </summary>
    [Serializable]
    public class CorpShareholderTotal : AopObject
    {
        /// <summary>
        /// 出资方式
        /// </summary>
        [XmlElement("funding_method")]
        public string FundingMethod { get; set; }

        /// <summary>
        /// 实缴币种
        /// </summary>
        [XmlElement("paid_currency")]
        public string PaidCurrency { get; set; }

        /// <summary>
        /// 持股比例
        /// </summary>
        [XmlElement("shareholding_percent")]
        public string ShareholdingPercent { get; set; }

        /// <summary>
        /// 持股类型
        /// </summary>
        [XmlElement("shareholding_type")]
        public string ShareholdingType { get; set; }

        /// <summary>
        /// 总持股数
        /// </summary>
        [XmlElement("shares_num")]
        public long SharesNum { get; set; }
    }
}
