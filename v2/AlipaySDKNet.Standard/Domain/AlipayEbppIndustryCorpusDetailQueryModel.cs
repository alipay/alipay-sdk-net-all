using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCorpusDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCorpusDetailQueryModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 知识语料类型
        /// </summary>
        [XmlElement("corpus_type")]
        public string CorpusType { get; set; }

        /// <summary>
        /// 机构自己保存的语料id
        /// </summary>
        [XmlElement("out_corpus_id")]
        public string OutCorpusId { get; set; }
    }
}
