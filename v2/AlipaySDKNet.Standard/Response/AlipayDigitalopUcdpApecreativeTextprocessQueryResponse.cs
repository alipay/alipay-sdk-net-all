using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeTextprocessQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativeTextprocessQueryResponse : AopResponse
    {
        /// <summary>
        /// 文本产出进度
        /// </summary>
        [XmlArray("text_produce_status_list")]
        [XmlArrayItem("text_produce_status")]
        public List<TextProduceStatus> TextProduceStatusList { get; set; }
    }
}
