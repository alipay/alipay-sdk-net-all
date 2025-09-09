using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryTaxPaymentrouteQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryTaxPaymentrouteQueryResponse : AopResponse
    {
        /// <summary>
        /// 1：银联模式 2：支付宝下单模式-直连 3：支付宝下单模式-间连 4：间连外跳
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 缴税路由查询流水号
        /// </summary>
        [XmlElement("query_id")]
        public string QueryId { get; set; }
    }
}
