using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmTtsmessageQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmTtsmessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 音转文列表
        /// </summary>
        [XmlArray("tts_message_list")]
        [XmlArrayItem("asr_tts_sls_message")]
        public List<AsrTtsSlsMessage> TtsMessageList { get; set; }
    }
}
