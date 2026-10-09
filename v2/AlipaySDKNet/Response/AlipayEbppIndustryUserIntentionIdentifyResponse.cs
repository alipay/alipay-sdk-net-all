using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryUserIntentionIdentifyResponse.
    /// </summary>
    public class AlipayEbppIndustryUserIntentionIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 意图信息列表
        /// </summary>
        [XmlElement("intention_info_list")]
        public IntentionInfo IntentionInfoList { get; set; }

        /// <summary>
        /// 用户原始query扩写后的结果
        /// </summary>
        [XmlArray("query_extension_list")]
        [XmlArrayItem("string")]
        public List<string> QueryExtensionList { get; set; }

        /// <summary>
        /// 用户原始输入之后的改写
        /// </summary>
        [XmlElement("query_rewrite")]
        public string QueryRewrite { get; set; }
    }
}
