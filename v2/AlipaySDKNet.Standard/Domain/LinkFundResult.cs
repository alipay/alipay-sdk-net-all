using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkFundResult Data Structure.
    /// </summary>
    [Serializable]
    public class LinkFundResult : AopObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 基金名称
        /// </summary>
        [XmlElement("fund_name")]
        public string FundName { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 费率
        /// </summary>
        [XmlElement("rate_list")]
        public ChargeRateDTO RateList { get; set; }
    }
}
