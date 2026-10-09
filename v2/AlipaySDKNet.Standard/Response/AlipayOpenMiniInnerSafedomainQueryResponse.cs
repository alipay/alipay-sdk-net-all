using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerSafedomainQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerSafedomainQueryResponse : AopResponse
    {
        /// <summary>
        /// 允许添加的最大域名数量限制
        /// </summary>
        [XmlElement("allow_add_count")]
        public long AllowAddCount { get; set; }

        /// <summary>
        /// 安全域名列表
        /// </summary>
        [XmlArray("safe_domains")]
        [XmlArrayItem("string")]
        public List<string> SafeDomains { get; set; }
    }
}
