using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterceptedCorpusResult Data Structure.
    /// </summary>
    [Serializable]
    public class InterceptedCorpusResult : AopObject
    {
        /// <summary>
        /// 拦截的描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 校验失败的id列表
        /// </summary>
        [XmlArray("out_corpus_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutCorpusIdList { get; set; }
    }
}
