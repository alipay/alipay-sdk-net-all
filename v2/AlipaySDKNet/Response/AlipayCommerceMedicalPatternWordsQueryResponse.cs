using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPatternWordsQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalPatternWordsQueryResponse : AopResponse
    {
        /// <summary>
        /// 底纹词数据列表
        /// </summary>
        [XmlArray("pattern_words")]
        [XmlArrayItem("pattern_word")]
        public List<PatternWord> PatternWords { get; set; }
    }
}
