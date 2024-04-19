using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordQuerystatusResponse.
    /// </summary>
    public class AlipayOpenSearchSubservicekeywordQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 关键词工单审核状态返回值
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("key_word_info")]
        public List<KeyWordInfo> KeyWords { get; set; }
    }
}
