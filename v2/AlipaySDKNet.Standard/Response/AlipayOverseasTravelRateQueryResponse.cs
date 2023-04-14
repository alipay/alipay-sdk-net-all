using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelRateQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelRateQueryResponse : AopResponse
    {
        /// <summary>
        /// 货币代码，ISO标准alpha- 3币种代码，为当前查询的币种、或者根据国家码、经纬度定位所在国家对应的币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 货币icon的url地址
        /// </summary>
        [XmlElement("currency_icon")]
        public string CurrencyIcon { get; set; }

        /// <summary>
        /// 支付宝会员等级，只有在入参user_id存在的情况下才返回
        /// </summary>
        [XmlElement("customer_level")]
        public string CustomerLevel { get; set; }

        /// <summary>
        /// 汇率，为支付宝当面付的当前币种/CNY的汇率值，如1美元=6.2345人民币元，即汇率为6.2345
        /// </summary>
        [XmlElement("rate")]
        public long Rate { get; set; }

        /// <summary>
        /// 汇率描述
        /// </summary>
        [XmlElement("rate_desc")]
        public string RateDesc { get; set; }

        /// <summary>
        /// 汇率来源说明
        /// </summary>
        [XmlElement("rate_source")]
        public string RateSource { get; set; }
    }
}
