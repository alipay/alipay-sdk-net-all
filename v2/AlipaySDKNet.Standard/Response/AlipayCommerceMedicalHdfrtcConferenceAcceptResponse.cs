using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcConferenceAcceptResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcConferenceAcceptResponse : AopResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }
    }
}
