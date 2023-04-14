using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchOrderwordnumQueryResponse.
    /// </summary>
    public class AlipayOpenSearchOrderwordnumQueryResponse : AopResponse
    {
        /// <summary>
        /// 可配置关键词数量
        /// </summary>
        [XmlElement("keyword_num")]
        public string KeywordNum { get; set; }
    }
}
