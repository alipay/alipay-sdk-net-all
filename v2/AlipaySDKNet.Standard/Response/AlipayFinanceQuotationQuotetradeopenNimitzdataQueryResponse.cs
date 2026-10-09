using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenNimitzdataQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenNimitzdataQueryResponse : AopResponse
    {
        /// <summary>
        /// Nimitz数据返回结果，Json结构
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
