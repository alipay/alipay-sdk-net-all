using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfappointmentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfappointmentQueryResponse : AopResponse
    {
        /// <summary>
        /// 响应内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
