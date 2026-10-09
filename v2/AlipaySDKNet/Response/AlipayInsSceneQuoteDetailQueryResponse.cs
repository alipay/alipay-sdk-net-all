using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneQuoteDetailQueryResponse.
    /// </summary>
    public class AlipayInsSceneQuoteDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 报价详情
        /// </summary>
        [XmlElement("quote_detail")]
        public InsQuoteDTO QuoteDetail { get; set; }
    }
}
