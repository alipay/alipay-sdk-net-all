using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCrowdMatchResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCrowdMatchResponse : AopResponse
    {
        /// <summary>
        /// 匹配成功的人群标签列表
        /// </summary>
        [XmlArray("match")]
        [XmlArrayItem("string")]
        public List<string> Match { get; set; }
    }
}
