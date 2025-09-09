using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterStopscheduleNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterStopscheduleNotifyResponse : AopResponse
    {
        /// <summary>
        /// 支持批量.registerIds 逗号分隔
        /// </summary>
        [XmlElement("register_ids")]
        public string RegisterIds { get; set; }
    }
}
