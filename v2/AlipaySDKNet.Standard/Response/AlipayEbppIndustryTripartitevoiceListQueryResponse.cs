using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryTripartitevoiceListQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryTripartitevoiceListQueryResponse : AopResponse
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voice_list")]
        [XmlArrayItem("tripartite_voice")]
        public List<TripartiteVoice> VoiceList { get; set; }
    }
}
