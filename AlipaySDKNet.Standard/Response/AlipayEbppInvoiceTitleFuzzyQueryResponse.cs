using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleFuzzyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleFuzzyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业名称列表
        /// </summary>
        [XmlArray("enterprise_name")]
        [XmlArrayItem("string")]
        public List<string> EnterpriseName { get; set; }
    }
}
