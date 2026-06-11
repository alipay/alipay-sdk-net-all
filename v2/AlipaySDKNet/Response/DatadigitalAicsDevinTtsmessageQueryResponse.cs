using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinTtsmessageQueryResponse.
    /// </summary>
    public class DatadigitalAicsDevinTtsmessageQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tts_message_list")]
        [XmlArrayItem("dt_asr_tts_sls_message")]
        public List<DtAsrTtsSlsMessage> TtsMessageList { get; set; }
    }
}
