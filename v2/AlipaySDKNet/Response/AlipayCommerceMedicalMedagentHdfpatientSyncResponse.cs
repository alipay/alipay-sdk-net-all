using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentHdfpatientSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentHdfpatientSyncResponse : AopResponse
    {
        /// <summary>
        /// aq就诊人ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
