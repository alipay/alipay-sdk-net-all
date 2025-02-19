using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBotQueryRecommendResponse.
    /// </summary>
    public class AlipayEbppIndustryBotQueryRecommendResponse : AopResponse
    {
        /// <summary>
        /// 详细介绍下社保缴纳标准
        /// </summary>
        [XmlArray("ask_more_list")]
        [XmlArrayItem("string")]
        public List<string> AskMoreList { get; set; }
    }
}
