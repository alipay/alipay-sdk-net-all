using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenTagQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenTagQueryResponse : AopResponse
    {
        /// <summary>
        /// 行情标签模型
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("obj_quote_tag_d_t_o")]
        public List<ObjQuoteTagDTO> Data { get; set; }
    }
}
