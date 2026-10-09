using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAudioSetResponse.
    /// </summary>
    public class SsdataDataserviceRiskAudioSetResponse : AopResponse
    {
        /// <summary>
        /// 查询出的关键词数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 关键词结果
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("string")]
        public List<string> KeywordList { get; set; }

        /// <summary>
        /// 结果是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
