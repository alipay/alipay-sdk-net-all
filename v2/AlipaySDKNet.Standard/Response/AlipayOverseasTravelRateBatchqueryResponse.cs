using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelRateBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTravelRateBatchqueryResponse : AopResponse
    {
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

        /// <summary>
        /// 多个币种汇率结果，currency:货币代码，ISO标准alpha- 3币种代码;  rate:当前币种/CNY的汇率,Number(15,8)  currency_icon:货币图片的url地址
        /// </summary>
        [XmlElement("rates")]
        public string Rates { get; set; }
    }
}
