using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcConferenceforadminQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcConferenceforadminQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("event_log_info_list")]
        [XmlArrayItem("event_log_info")]
        public List<EventLogInfo> EventLogInfoList { get; set; }
    }
}
