using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceFundFundnetvaluesBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceFundFundnetvaluesBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 基金类型，如：STOCK，BLEND，INDEX，BOND，CURRENCY，QDII，SHORTDATED，FOF
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 基金净值列表
        /// </summary>
        [XmlArray("net_values")]
        [XmlArrayItem("net_value_v_o")]
        public List<NetValueVO> NetValues { get; set; }
    }
}
