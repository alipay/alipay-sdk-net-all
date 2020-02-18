using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse.
    /// </summary>
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回机构关键词相关信息
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("string")]
        public List<string> Result { get; set; }
    }
}
